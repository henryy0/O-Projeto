using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace O_Projeto
{
    public partial class Frmcadastro : Form
    {
        public Frmcadastro()
        {
            InitializeComponent();
        }

        string stringConexao = "Data Source=localhost;Initial Catalog=SistemaDeGerenciamento;User ID=sa;Password=123456";

        private void Frmcadastro_Load(object sender, EventArgs e)
        {

        }

        private void btosair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btocadastrar_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO usuario " +
                         "(nome_usuario, login_usuario, senha_usuario) " +
                         "VALUES " +
                         "('" + txtNome.Text + "', '" + txtLogin.Text + "', '" + txtSenha.Text + "'); " +
                         "SELECT SCOPE_IDENTITY();";

            frmlogin login = new frmlogin();
            login.Show();

            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;

            try
            {
                conexao.Open();
                int newUserId = Convert.ToInt32(cmd.ExecuteScalar());

                if (newUserId > 0)
                {
                    MessageBox.Show("Cadastro realizado com sucesso");
                }
                else
                {
                    MessageBox.Show("Nenhum registro inserido. Verifique os dados.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}

