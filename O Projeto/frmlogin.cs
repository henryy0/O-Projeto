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


namespace O_Projeto


{

    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        string stringConexao = MDIPrincipal.stringConexao;

        private void btoentrar_Click(object sender, EventArgs e)
        {
            string sql = "select * from usuario where " +
                "login_usuario = '" + txtLogin.Text + "' and " +
                "senha_usuario = '" + txtSenha.Text + "'";

            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;
            conexao.Open();
            try
            {
                leitura = cmd.ExecuteReader();

                if (leitura.Read())
                {
                    MDIPrincipal.nomeUsuario = leitura[1].ToString();
                    MDIPrincipal.loginUsuario = leitura[2].ToString();
                    this.Close();
                    MDIPrincipal MDI = new MDIPrincipal();
                    MDI.Show();
                }
                else
                {
                    MessageBox.Show("Erro, usuário ou senha inválido");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro, " + ex.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Frmcadastro Cadastro = new Frmcadastro();
            Cadastro.Show();
        }
    }
}