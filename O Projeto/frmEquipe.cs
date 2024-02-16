using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Text;

namespace O_Projeto
{
    public partial class frmEquipe : Form
    {
        private const string ConnectionString = "Data Source=localhost;Initial Catalog=SistemaDeGerenciamento;User ID=sa;Password=123456";
        private const int Spacing = 10;
        private int lastGroupBoxBottom = 10;

        public frmEquipe()
        {
            InitializeComponent();

            Button btoEquipe = new Button
            {
                Name = "btoEquipe",
                Text = "Preencher Equipes",
                Location = new Point(10, 10),
                Size = new Size(120, 30),
                BackColor = Color.Blue,
                ForeColor = Color.White
            };

            btoEquipe.Click += btoEquipe_Click;

            this.Controls.Add(btoEquipe);

            var btnAdicionarEquipe = new Button
            {
                Text = "Adicionar Equipe",
                Location = new Point(140, 10),
                BackColor = Color.Green,
                ForeColor = Color.White
            };

            btnAdicionarEquipe.Click += BtnAdicionarEquipe_Click;
            this.Controls.Add(btnAdicionarEquipe);
        }

        private void btoEquipe_Click(object sender, EventArgs e)
        {
            PreencherEquipes();
        }

        private DataTable GetEquipesFromDatabase()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (var conexao = new SqlConnection(ConnectionString))
                {
                    conexao.Open();

                    const string QuerySelect = "SELECT e.equipe_id, e.equipe_nome, e.equipe_descricao, " +
                                               "p.Nome_Projeto AS NomeDoProjeto, p.ID_Projeto, " +
                                               "l.nome_usuario AS NomeLider " +
                                               "FROM Equipe e " +
                                               "LEFT JOIN Projeto p ON e.Projeto_atribuido_ID = p.ID_Projeto " +
                                               "LEFT JOIN usuario l ON e.equipe_lider_id = l.id_usuario";

                    using (var comandoSelect = new SqlCommand(QuerySelect, conexao))
                    {
                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter(comandoSelect))
                        {
                            dataAdapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao obter as equipes. Detalhes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dataTable;
        }

        private void PreencherEquipes()
        {
            Panel panelEquipes = new Panel
            {
                Location = new Point(10, lastGroupBoxBottom + Spacing * 2),
                AutoScroll = true,
                Width = this.Width - 30,
                Height = this.Height - lastGroupBoxBottom - Spacing * 3
            };

            DataTable dataTable = GetEquipesFromDatabase();

            lastGroupBoxBottom = 10;

            foreach (DataRow row in dataTable.Rows)
            {
                GroupBox groupBox = new GroupBox
                {
                    Text = row["equipe_nome"].ToString(),
                    Size = new Size(panelEquipes.Width - 20, 120), // Aumente a altura da GroupBox
                    Location = new Point(10, lastGroupBoxBottom + Spacing),
                };

                Label labelDescricao = new Label
                {
                    Text = row["equipe_descricao"].ToString(),
                    Location = new Point(10, 20),
                    AutoSize = true,
                    Width = groupBox.Width - 20 // Ajuste a largura para evitar que o texto seja cortado
                };

                Label labelProjeto = new Label
                {
                    Text = $"Projeto Atribuído: {row["NomeDoProjeto"].ToString()}",
                    Location = new Point(10, 50),
                    AutoSize = true,
                    ForeColor = Color.Blue,
                    Cursor = Cursors.Hand
                };

                Label labelLider = new Label
                {
                    Text = $"Líder: {row["NomeLider"].ToString()}",
                    Location = new Point(10, 80),
                    AutoSize = true,
                    ForeColor = Color.Red,
                    Cursor = Cursors.Hand
                };

                labelProjeto.Click += (sender, e) => MostrarTarefasDoProjeto(row["ID_Projeto"].ToString());

                groupBox.Controls.Add(labelDescricao);
                groupBox.Controls.Add(labelProjeto);
                groupBox.Controls.Add(labelLider);

                panelEquipes.Controls.Add(groupBox);

                lastGroupBoxBottom = groupBox.Bottom + Spacing;
            }

            this.Controls.Add(panelEquipes);
        }

        private void MostrarTarefasDoProjeto(string idProjeto)
        {
            DataTable dataTable = GetTarefasFromDatabase(idProjeto);

            if (dataTable.Rows.Count > 0)
            {
                StringBuilder tasksMessage = new StringBuilder();
                tasksMessage.AppendLine($"Tarefas do Projeto (ID: {idProjeto}):");

                foreach (DataRow row in dataTable.Rows)
                {
                    tasksMessage.AppendLine($"- {row["Nome_tarefa"].ToString()} ({row["Status_tarefa"].ToString()})");
                }

                MessageBox.Show(tasksMessage.ToString(), "Tarefas do Projeto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nenhuma tarefa encontrada para o projeto.", "Tarefas do Projeto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private DataTable GetTarefasFromDatabase(string idProjeto)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (var conexao = new SqlConnection(ConnectionString))
                {
                    conexao.Open();

                    string querySelectTarefas = $"SELECT * FROM Tarefa WHERE Projeto_tarefa = {idProjeto}";

                    using (var comandoSelectTarefas = new SqlCommand(querySelectTarefas, conexao))
                    {
                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter(comandoSelectTarefas))
                        {
                            dataAdapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao obter as tarefas. Detalhes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dataTable;
        }

        private void BtnAdicionarEquipe_Click(object sender, EventArgs e)
        {
            using (var formNovaEquipe = new frmNovaEquipe())
            {
                if (formNovaEquipe.ShowDialog() == DialogResult.OK)
                {
                    AdicionarNovaEquipe(formNovaEquipe);
                    PreencherEquipes();
                }
            }
        }

        private void AdicionarNovaEquipe(frmNovaEquipe formNovaEquipe)
        {
            try
            {
                using (var conexao = new SqlConnection(ConnectionString))
                {
                    conexao.Open();

                    const string QueryInsert = "INSERT INTO Equipe (equipe_nome, equipe_descricao, equipe_lider_id, Projeto_atribuido_ID) " +
                                              "VALUES (@Nome, @Descricao, @LiderID, @ProjetoAtribuidoID)";

                    using (var comandoInsert = new SqlCommand(QueryInsert, conexao))
                    {
                        comandoInsert.Parameters.AddWithValue("@Nome", formNovaEquipe.GetNomeEquipe());
                        comandoInsert.Parameters.AddWithValue("@Descricao", formNovaEquipe.GetDescricaoEquipe());
                        comandoInsert.Parameters.AddWithValue("@LiderID", formNovaEquipe.GetLiderID());
                        comandoInsert.Parameters.AddWithValue("@ProjetoAtribuidoID", formNovaEquipe.GetProjetoAtribuidoID());

                        comandoInsert.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao adicionar a equipe. Detalhes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
