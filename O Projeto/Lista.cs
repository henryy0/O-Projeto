using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace O_Projeto
{
    public partial class Lista : Form
    {
        private int spacing = 10;
        private int lastGroupBoxBottom = 0;
        private string tipoProjeto;
        private DateTime dataInicioProjeto;
        private DateTime dataFimProjeto;
        private string statusProjeto;
        private string riscosProjeto;
        private int orcamentoProjeto;
        private string recursosProjeto;
        private string connectionString = "Data Source=localhost;Initial Catalog=sistemaDeGerenciamento;User ID=sa;Password=123456";

        public Lista()
        {
            InitializeComponent();
        }

        private void Lista_Load(object sender, EventArgs e)
        {
            PreencherFormulario();
            CreateButtonPanel();
        }


        private void BtnAdicionarProjeto_Click(object sender, EventArgs e)
        {
            using (frmProjeto projetos = new frmProjeto())
            {
                if (projetos.ShowDialog() == DialogResult.OK)
                {
                    AdicionarNovoProjeto(projetos);
                }
            }
        }

        private void RefreshForm()
        {
            Controls.Clear();

            PreencherFormulario();
        }

        public void AdicionarNovoProjeto(frmProjeto projetos)
        {
            RefreshForm();
        }

        private void CreateButtonPanel()
        {
            Panel buttonPanel = new Panel
            {
                Dock = DockStyle.Right,
                Width = 120,
                BackColor = Color.Gray
            };

            AddButton(buttonPanel, @"C:\Users\carlos.hnsilva1\Downloads\Calender.png", btoCalendario_Click);
            AddButton(buttonPanel, @"C:\Users\carlos.hnsilva1\Downloads\Chat.png", btoChat_Click);
            AddButton(buttonPanel, @"C:\Users\carlos.hnsilva1\Downloads\Project.png", btoProjetos_Click);
            AddButton(buttonPanel, @"C:\Users\carlos.hnsilva1\Downloads\Tasks.png", btoTarefa_Click);
            AddButton(buttonPanel, @"C:\Users\carlos.hnsilva1\Downloads\Teams.png", btoTeam_Click);
            AddButton(buttonPanel, @"C:\Users\carlos.hnsilva1\Downloads\Relatorio.png", btoRelatorio_Click);

            Controls.Add(buttonPanel);
        }

        private void AddButton(Panel panel, string imagePath, EventHandler eventHandler)
        {
            int buttonHeight = 80;
            int spacing = 10;

            Button button = new Button
            {
                Image = Image.FromFile(imagePath),
                TextAlign = ContentAlignment.MiddleRight,
                Size = new Size(panel.Width - 10, buttonHeight), 
                FlatStyle = FlatStyle.Flat,
                Location = new Point(0, (buttonHeight + spacing) * panel.Controls.Count) 
            };

            button.Click += eventHandler;
            panel.Controls.Add(button);
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
            frmTarefa tarefa = new frmTarefa();
            tarefa.Show();
        }

        private void btoRelatorio_Click(object sender, EventArgs e)
        {
            frmrelatorio relatorio = new frmrelatorio();
            relatorio.Show();
        }

        private void btoTeam_Click(object sender, EventArgs e)
        {
            // Lógica para o botão Equipes
        }


        private void PreencherFormulario()
        {
            string query = "SELECT Nome_Projeto, Resumo_Projeto FROM Projeto";

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(query, connection))
            {
                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    int contador = 0;

                    var groupBoxX = 140; 
                    var groupBoxWidth = 720; 
                    var btnAdicionarX = groupBoxX + groupBoxWidth + spacing; 

                    while (reader.Read())
                    {
                        string nomeProjeto = reader["Nome_Projeto"].ToString();
                        string resumoProjeto = reader["Resumo_Projeto"].ToString();

                        var groupBox = new GroupBox
                        {
                            Width = groupBoxWidth, 
                            Height = 220,
                            BackColor = Color.Black
                        };

                        groupBox.Location = new Point(groupBoxX, lastGroupBoxBottom + spacing);

                        GraphicsPath path = new GraphicsPath();
                        int arcRadius = 20;
                        int borderWidth = 2;
                        path.AddArc(0, 0, arcRadius, arcRadius, 180, 90);
                        path.AddLine(arcRadius, 0, groupBox.Width - arcRadius, 0);
                        path.AddArc(groupBox.Width - arcRadius, 0, arcRadius, arcRadius, -90, 90);
                        path.AddLine(groupBox.Width, arcRadius, groupBox.Width, groupBox.Height - arcRadius);
                        path.AddArc(groupBox.Width - arcRadius, groupBox.Height - arcRadius, arcRadius, arcRadius, 0, 90);
                        path.AddLine(groupBox.Width - arcRadius, groupBox.Height, arcRadius, groupBox.Height);
                        path.AddArc(0, groupBox.Height - arcRadius, arcRadius, arcRadius, 90, 90);
                        path.AddLine(0, groupBox.Height - arcRadius, 0, arcRadius);
                        path.CloseFigure();
                        groupBox.Region = new Region(path);

                        var labelNome = new Label
                        {
                            Text = nomeProjeto,
                            Location = new System.Drawing.Point(10, 10),
                            Font = new Font("Arial", 18, FontStyle.Bold),
                            ForeColor = Color.White,
                            Width = 150,
                            Height = 40
                        };

                        var labelResumo = new Label
                        {
                            Text = resumoProjeto,
                            Location = new System.Drawing.Point(10, 50),
                            Font = new Font("Arial", 12),
                            ForeColor = Color.White,
                            Width = groupBox.Width - 20,
                            Height = groupBox.Height - 90,
                            AutoEllipsis = true,
                        };

                        var editButton = new Button
                        {
                            Location = new Point(groupBox.Width - 70, 10),
                            Size = new Size(40, 40),
                            BackgroundImage = Image.FromFile(@"C:\Users\carlos.hnsilva1\Downloads\Imagem Edição.png"),
                            BackgroundImageLayout = ImageLayout.Stretch,
                        };

                        editButton.Click += (s, eventArgs) =>
                        {
                            frmEdicao formEdicao = new frmEdicao();

                            formEdicao.PreencherDadosProjeto(nomeProjeto, tipoProjeto, dataInicioProjeto, dataFimProjeto, statusProjeto, resumoProjeto, riscosProjeto, orcamentoProjeto, recursosProjeto);

                            formEdicao.ShowDialog();

                            if (formEdicao.SalvarAlteracoes)
                            {
                                string novoNomeProjeto = formEdicao.GetNomeProjeto();
                                string novoTipoProjeto = formEdicao.GetTipoProjeto();
                                DateTime novaDataInicioProjeto = formEdicao.GetDataInicioProjeto();
                                DateTime novaDataFimProjeto = formEdicao.GetDataFimProjeto();
                                string novoStatusProjeto = formEdicao.GetStatusProjeto();
                                string novoResumoProjeto = formEdicao.GetResumoProjeto();
                                string novosRiscosProjeto = formEdicao.GetRiscosProjeto();
                                int novoOrcamentoProjeto = formEdicao.GetOrcamentoProjeto();
                                string novosRecursosProjeto = formEdicao.GetRecursosProjeto();

                                using (var conexao = new SqlConnection(connectionString))
                                {
                                    conexao.Open();

                                    string queryUpdate = "UPDATE Projeto SET Nome_Projeto = @Nome, Tipo_Projeto = @Tipo, " +
                                                         "Data_inicio_Projeto = @DataInicio, Data_Fim_Projeto = @DataFim, " +
                                                         "Status_Projeto = @Status, Resumo_Projeto = @Resumo, " +
                                                         "Riscos_Projeto = @Riscos, Orçamento_Projeto = @Orcamento, Recursos_Projeto = @Recursos " +
                                                         "WHERE Nome_Projeto = @NomeProjeto";

                                    using (var comandoUpdate = new SqlCommand(queryUpdate, conexao))
                                    {
                                        comandoUpdate.Parameters.AddWithValue("@Nome", novoNomeProjeto);
                                        comandoUpdate.Parameters.AddWithValue("@Tipo", novoTipoProjeto);
                                        comandoUpdate.Parameters.AddWithValue("@DataInicio", novaDataInicioProjeto);
                                        comandoUpdate.Parameters.AddWithValue("@DataFim", novaDataFimProjeto);
                                        comandoUpdate.Parameters.AddWithValue("@Status", novoStatusProjeto);
                                        comandoUpdate.Parameters.AddWithValue("@Resumo", novoResumoProjeto);
                                        comandoUpdate.Parameters.AddWithValue("@Riscos", novosRiscosProjeto);
                                        comandoUpdate.Parameters.AddWithValue("@Orcamento", novoOrcamentoProjeto);
                                        comandoUpdate.Parameters.AddWithValue("@Recursos", novosRecursosProjeto);
                                        comandoUpdate.Parameters.AddWithValue("@NomeProjeto", nomeProjeto);

                                        comandoUpdate.ExecuteNonQuery();
                                    }
                                }

                                labelNome.Text = novoNomeProjeto;
                            }
                        };

                        groupBox.Controls.Add(labelNome);
                        groupBox.Controls.Add(labelResumo);
                        groupBox.Controls.Add(editButton);

                        groupBox.Location = new Point(10, lastGroupBoxBottom + spacing);

                        lastGroupBoxBottom = groupBox.Bottom;

                        this.Controls.Add(groupBox);
                        contador++;
                    }

                    var btnAdicionarProjeto = new Button
                    {
                        Text = "Adicionar Projeto",
                        Location = new Point(10, lastGroupBoxBottom + spacing),
                        BackColor = Color.Green,
                        ForeColor = Color.White
                    };

                    this.AutoScroll = true;

                    btnAdicionarProjeto.Click += BtnAdicionarProjeto_Click;
                    this.Controls.Add(btnAdicionarProjeto);
                }
            }
        }
    }
}
