using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckPecas
{
    public partial class FrmLogin : Form
    {
        string strConexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=check_peca;Integrated Security=True;TrustServerCertificate=True";

        SqlConnection objConexao;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string senha = string.Empty;
            objConexao = new SqlConnection(strConexao);
            SqlCommand cmd = new SqlCommand("SELECT senha FROM usuarios WHERE email = @email", objConexao);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);

            objConexao.Open();

            object result = cmd.ExecuteScalar();

            if (result != null)
            {
                senha = result.ToString();
            }
            else 
            {
                cmd.CommandText = "INSERT INTO usuarios VALUES (@emai, @senha)";
                cmd.Parameters.AddWithValue("@emai", txtEmail.Text);
                cmd.Parameters.AddWithValue("@senha", txtSenha.Text);
                cmd.ExecuteNonQuery();
                this.Hide();
                FrmPrincipal frmPrincipal = new FrmPrincipal();
                frmPrincipal.Show();

                txtEmail.ResetText();
                txtSenha.ResetText();
            }

            objConexao.Close();

            if (senha == txtSenha.Text)
            {
                this.Hide();
                FrmPrincipal frmPrincipal = new FrmPrincipal();
                frmPrincipal.Show();

                txtEmail.ResetText();
                txtSenha.ResetText();

            }
            else
            {
                MessageBox.Show("Senha incorreta!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.ResetText();
                txtSenha.ResetText();
            }

           
        }
    }
}
