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
    public partial class frmTarefa : Form
    {
        public frmTarefa()
        {
            InitializeComponent();
        }

        private void Criar_Tarefa_Load(object sender, EventArgs e)
        {
            CarregarComboProjeto();
            TestarConexao();
        }


        string stringConexao = "Data Source=localhost;Initial Catalog=sistemaDeGerenciamento;User ID=sa;Password=123456";


        private void TestarConexao()
        {
            SqlConnection conexao = new SqlConnection(stringConexao);

            try
            {
                conexao.Open();
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
                Application.Exit();
            }
        }

        private void CarregarComboProjeto()
        {
            string sql = "SELECT Id_Projeto, Nome_Projeto FROM Projeto";

            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;

            DataTable tabela = new DataTable();

            conexao.Open();

            try
            {
                leitura = cmd.ExecuteReader();

                tabela.Load(leitura);

                cboProjeto.DisplayMember = "Nome_Projeto";  
                cboProjeto.ValueMember = "Id_Projeto";     
                cboProjeto.DataSource = tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btoAdicionar_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Tarefa (Projeto_tarefa, Nome_tarefa, Data_inicio_Projeto, Data_Fim_Projeto, Obs_tarefa, Status_tarefa) " +
                         "VALUES (@Projeto, @NomeTarefa, @DataInicio, @DataTermino, @Obs, @Status); SELECT SCOPE_IDENTITY()";

            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;

            // Adicione parâmetros para evitar SQL injection
            cmd.Parameters.AddWithValue("@Projeto", cboProjeto.SelectedValue);
            cmd.Parameters.AddWithValue("@NomeTarefa", txtNomeTarefa.Text);
            cmd.Parameters.AddWithValue("@DataInicio", txtDataInicio.Text);
            cmd.Parameters.AddWithValue("@DataTermino", txtDataTermino.Text);
            cmd.Parameters.AddWithValue("@Obs", txtObs.Text);
            cmd.Parameters.AddWithValue("@Status", cboStatus.Text);

            conexao.Open();

            try
            {
                // ExecuteScalar para obter o ID inserido
                int idTarefa = Convert.ToInt32(cmd.ExecuteScalar());
                MessageBox.Show($"Tarefa cadastrada com sucesso. ID da Tarefa: {idTarefa}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
    }


        private void btoExcluir_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM Tarefa WHERE Projeto_tarefa = @Projeto";

            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;

            // Adicione parâmetros para evitar SQL injection
            cmd.Parameters.AddWithValue("@Projeto", cboProjeto.SelectedValue);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tarefa excluída com sucesso.");
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

    private void btoTarefa_Click(object sender, EventArgs e)
        {
            frmTarefa Tarefa = new frmTarefa();
            Tarefa.Show();
        }

        private void btoCalendario_Click(object sender, EventArgs e)
        {
            Calendario calendario = new Calendario();
            calendario.Show();
        }

        private void btoProjetos_Click(object sender, EventArgs e)
        {
            frmProjeto projeto = new frmProjeto();
            projeto.Show();
        }

        private void btoChat_Click(object sender, EventArgs e)
        {
            frmChat Chat = new frmChat();
            Chat.Show();
        }
    }
}
