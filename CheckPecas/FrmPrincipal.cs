using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckPecas
{
    public partial class FrmPrincipal : Form
    {
        string strConexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=check_peca;Integrated Security=True;TrustServerCertificate=True";

        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                SqlCommand cmd = new SqlCommand("SELECT nome FROM Pecas", objConexao);
                cmd.Parameters.AddWithValue("@nome", cbPecas.Text);

                objConexao.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nome = reader["nome"].ToString();
                        cbPecas.Items.Add(nome);
                    }
                }
                objConexao.Close();

            }
        }
        private void mtxtData_Leave(object sender, EventArgs e)
        {
            DateTime enteredDate;
            if (!DateTime.TryParse(mtxtData.Text, out enteredDate))
            {
                MessageBox.Show("Data inválida. Por favor, insira uma data válida no formato DD/MM/AAAA.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtxtData.Focus();
                return;
            }

            if (enteredDate > DateTime.Now)
            {
                MessageBox.Show("A data deve ser igual ou anterior à data atual.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtxtData.Focus();
                return;
            }
        }
        private void cbPecas_TextChanged(object sender, EventArgs e)
        {
            if (cbPecas.Items != null && mtxtData.Text != null)
            {
                numericAprovadas.Enabled = true;
                numericReprovadas.Enabled = true;
            }
        }

        private void numericAprovadas_ValueChanged(object sender, EventArgs e)
        {
            int aprovadas = int.Parse(numericAprovadas.Value.ToString());
            int reprovadas = int.Parse(numericReprovadas.Value.ToString());


            txtProduzidas.Text = (aprovadas + reprovadas).ToString();
        }
        private void numericReprovadas_ValueChanged(object sender, EventArgs e)
        {
            int aprovadas = int.Parse(numericAprovadas.Value.ToString());
            int reprovadas = int.Parse(numericReprovadas.Value.ToString());
            if (reprovadas > aprovadas)
            {
                MessageBox.Show("O número de peças reprovadas não deve ser maior que peças aprovadas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numericReprovadas.Value = 0;
            }
            else
            {
                txtProduzidas.Text = (aprovadas + reprovadas).ToString();
            }

            if (reprovadas > 10)
            {
                txtEmail.Enabled = true;

            }
        }
        private void txtProduzidas_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                SqlCommand cmd = new SqlCommand("SELECT prejuizoPorPeca FROM Pecas WHERE nome = @nome", objConexao);
                cmd.Parameters.AddWithValue("@nome", cbPecas.SelectedItem);
                cmd.Parameters.AddWithValue("@valor", txtPrejuizo.Text);
                string valor = "";

                objConexao.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        valor = reader["prejuizoPorPeca"].ToString();
                    }
                }

                double prejuizo = double.Parse(valor) * double.Parse(numericReprovadas.Value.ToString());
                txtPrejuizo.Text = prejuizo.ToString("C2");

                objConexao.Close();
            }
        }

        private bool ValidarEmail(string email)
        {
            string regras = @"^[a-zA-Z]{3,}@[a-zA-Z0-9]+(\.[a-zA-Z]{2,})+$";
            return Regex.IsMatch(email, regras);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            ValidarEmail(txtEmail.Text);
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Enabled && !ValidarEmail(txtEmail.Text))
            {
                MessageBox.Show("Por favor, insira um e-mail válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnSalvas_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mtxtData.Text) || cbPecas.SelectedItem == null ||
                string.IsNullOrEmpty(mtxtHrInicial.Text) || string.IsNullOrEmpty(mtxtHrFinal.Text) ||
                !ValidarEmail(txtEmail.Text))
            {
                MessageBox.Show("Informações incompletas. Preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TimeSpan horaInicial;
                TimeSpan horaFinal;
           
                if (!TimeSpan.TryParse(mtxtHrInicial.Text, out horaInicial))
                {
                    MessageBox.Show("Hora inicial inválida. Por favor, use o formato hh:mm.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!TimeSpan.TryParse(mtxtHrFinal.Text, out horaFinal))
                {
                    MessageBox.Show("Hora final inválida. Por favor, use o formato hh:mm.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (horaFinal < horaInicial)
                {
                    MessageBox.Show("A hora final deve ser maior ou igual à hora inicial.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                TimeSpan tempo = horaFinal - horaInicial;

                using (SqlConnection objConexao = new SqlConnection(strConexao))
                {
                    string insert = "INSERT INTO Producao VALUES (@dataProducao, @peca, @horaInicial, @horaFinal, @tempo)";

                    using (SqlCommand cmd = new SqlCommand(insert, objConexao))
                    {
                        cmd.Parameters.AddWithValue("@dataProducao", DateTime.Parse(mtxtData.Text));
                        cmd.Parameters.AddWithValue("@peca", cbPecas.Text);
                        cmd.Parameters.AddWithValue("@horaInicial", horaInicial);
                        cmd.Parameters.AddWithValue("@horaFinal", horaFinal);
                        cmd.Parameters.AddWithValue("@tempo", tempo);

                        objConexao.Open();
                        cmd.ExecuteNonQuery();
                        objConexao.Close();
                    }
                }
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            Relatorio relatorio = new Relatorio();
            relatorio.Show();
        }
 
    }
}
