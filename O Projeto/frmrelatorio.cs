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
    public partial class frmrelatorio : Form
    {
        public frmrelatorio()
        {
            InitializeComponent();
        }

        string stringConexao = "" +
            "Data Source=localhost;" +
            "Initial Catalog=SistemaDeGerenciamento;" +
            "User ID=sa;" +
            "Password=123456";


        private void frmrelatorio_Load(object sender, EventArgs e)
        {
            carregarDataGridRelatorio();
        }


        private void carregarDataGridRelatorio()
        {
            string sql = "SELECT ID_tarefa as 'ID', " +
              "Nome_tarefa as 'Nome', " +
              "Data_inicio_Projeto as 'Data Início', " +
              "Data_Fim_Projeto as 'Data Fim', " +
              "Obs_tarefa as 'Observação', " +
              "Status_tarefa as 'Status' " +
              "FROM Tarefa " + "where Projeto_tarefa like '%" + txtNomePesquisa.Text + "%'";

            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlDataAdapter ad = new SqlDataAdapter(sql, conexao);
            DataSet ds = new DataSet();

            conexao.Open();

            try
            {
                ad.Fill(ds);

                dataGridRelatorio.DataSource = ds.Tables[0];
                dataGridRelatorio.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridRelatorio.AutoResizeRow(0, DataGridViewAutoSizeRowMode.AllCellsExceptHeader);

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

        private void botPesquisar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCodigo.Text, out int idProjeto))
            {
                string sql = "SELECT * FROM Projeto WHERE ID_Projeto = @idProjeto";

                using (SqlConnection conexao = new SqlConnection(stringConexao))
                {
                    conexao.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@idProjeto", idProjeto);
                        cmd.CommandType = CommandType.Text;

                        using (SqlDataReader leitura = cmd.ExecuteReader())
                        {
                            if (leitura.Read())
                            {
                                txtCodigo.Text = leitura["ID_Projeto"].ToString();
                                labelNomeProjeto.Text = leitura["Nome_Projeto"].ToString();
                                labelResumo.Text = leitura["Resumo_Projeto"].ToString();
                                txtCronograma.Text = $"Início: {leitura["Data_inicio_Projeto"]}, Fim: {leitura["Data_Fim_Projeto"]}";
                                txtResumo.Text = $"Tipo: {leitura["Tipo_Projeto"]}, Status: {leitura["Status_Projeto"]}";
                                txtRiscos.Text = leitura["Riscos_Projeto"].ToString();
                                txtOrçamento.Text = leitura["Orçamento_Projeto"].ToString();
                                txtRecursos.Text = leitura["Recursos_Projeto"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Erro: Projeto não encontrado");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Erro: ID do Projeto não foi especificado ou é inválido.");
            }
        }

        private void dataGridRelatorio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}