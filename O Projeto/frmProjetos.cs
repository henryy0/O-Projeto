using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace O_Projeto
{
    public partial class frmProjeto : Form

    {
        string stringConexao = "Data Source=localhost;Initial Catalog=sistemaDeGerenciamento;User ID=sa;Password=123456";


        public frmProjeto()
        {
            InitializeComponent();
        }

        private void frmCriarProjeto_Load_1(object sender, EventArgs e)
        {
            TestarConexao();
        }


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



        private void btoExcluir_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM Projeto WHERE Nome_Projeto = '" + txtNomeProjeto.Text + "'";
            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;

            try
            {
                conexao.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Projeto excluído com sucesso.");
                }
                else
                {
                    MessageBox.Show("Projeto não encontrado.");
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

        private void btoAdicionar_Click_1(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Projeto (Nome_Projeto, Tipo_Projeto, Data_Inicio_Projeto, Data_Fim_Projeto, Status_Projeto, Resumo_Projeto, Riscos_Projeto, Orçamento_Projeto, Recursos_Projeto) " +
          "VALUES ('" + txtNomeProjeto.Text + "', '" + cboCategoria.Text + "', '" + txtDataInicio.Text + "', '" + txtDataTermino.Text + "', '" + cboStatus.Text + "', '" + txtResumo.Text + "',  '" + txtRiscos.Text + "', '" + txtOrc.Text + "', '" + txtRecursos.Text + "')";

            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;

            try
            {
                conexao.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Projeto adicionado com sucesso.");
                }
                else
                {
                    MessageBox.Show("Erro ao adicionar o projeto.");
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

        private void btoCalendario_Click(object sender, EventArgs e)
        {
            Calendario calendario = new Calendario();
            calendario.Show();
        }

        private void btoChat_Click(object sender, EventArgs e)
        {
            frmChat Chat = new frmChat();
            Chat.Show();
        }

        private void btoProjetos_Click(object sender, EventArgs e)
        {
            frmProjeto projeto = new frmProjeto();
            projeto.Show();
        }

        private void btoTarefa_Click(object sender, EventArgs e)
        {
            frmTarefa Tarefa = new frmTarefa();
            Tarefa.Show();
        }

        private void btoEditar_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE Projeto " +
                      "SET Tipo_Projeto = '" + cboCategoria + "', " +
                      "Data_Inicio_Projeto = '" + txtDataInicio + "', " +
                      "Data_Fim_Projeto = '" + txtDataTermino + "', " +
                      "Status_Projeto = '" + cboStatus + "', " +
                      "Resumo_Projeto = '" + txtResumo + "', " +
                      "Riscos_Projeto = '" + txtRiscos + "', " +
                      "Orçamento_Projeto = '" + txtOrc + "', " +
                      "Recursos_Projeto = '" + txtRecursos + "' " +
                      "WHERE Nome_Projeto = '" + txtNomeProjeto + "'";

            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;

            try
            {
                conexao.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Projeto atualizado com sucesso.");
                }
                else
                {
                    MessageBox.Show("Projeto não encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
        }
    }
}


