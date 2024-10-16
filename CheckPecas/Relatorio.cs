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
    public partial class Relatorio : Form
    {
        string strConexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=check_peca;Integrated Security=True;TrustServerCertificate=True";
        public Relatorio()
        {
            InitializeComponent();
        }

        public void Relatorio_Load(object sender, EventArgs e)
        {
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                string query = "SELECT * FROM Producao";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, objConexao);
                DataTable dataTable = new DataTable();
                //essa try-catch é bom pra tratar excessao. Dentro do try colocar um código q pode gerar um erro,
                //dentro do catch caso esse erro aconteca exibe a mensagem q eu escolhi
                try
                {
                    objConexao.Open();
                    dataAdapter.Fill(dataTable);
                    objConexao.Close();
                    dataGridRelatorio.DataSource = dataTable;
                    dataGridRelatorio.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar o relatório: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
