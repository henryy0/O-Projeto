using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace O_Projeto
{
    public partial class frmChat2 : Form
    {
        private string stringConexao = "Data Source=localhost;Initial Catalog=sistemaDeGerenciamento;User ID=sa;Password=123456";
        private MensagemDAO mensagemDAO;

        public frmChat2()
        {
            InitializeComponent();
            CarregarComboUsuario();
            mensagemDAO = new MensagemDAO(stringConexao);
            InicializarDataGridView();
            CarregarMensagens(); // Carrega as mensagens ao iniciar o formulário
        }

        private void CarregarComboUsuario()
        {
            string sql = "SELECT id_usuario, nome_usuario FROM usuario";

            using (SqlConnection conexao = new SqlConnection(stringConexao))
            {
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.CommandType = CommandType.Text;

                DataTable tabela = new DataTable();

                try
                {
                    conexao.Open();
                    SqlDataReader leitura = cmd.ExecuteReader();
                    tabela.Load(leitura);

                    cboUsuario1.DisplayMember = "nome_usuario";
                    cboUsuario1.ValueMember = "id_usuario";
                    cboUsuario1.DataSource = tabela;

                    DataTable tabelaUsuario2 = tabela.Clone();
                    tabelaUsuario2.Merge(tabela);

                    cboUsuario2.DisplayMember = "nome_usuario";
                    cboUsuario2.ValueMember = "id_usuario";
                    cboUsuario2.DataSource = tabelaUsuario2;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro " + ex.ToString());
                }
            }
        }

        private void InicializarDataGridView()
        {
            // Certifique-se de limpar as colunas existentes
            dataGridViewMensagens.Columns.Clear();

            // Defina as colunas necessárias
            dataGridViewMensagens.Columns.Add("id_chat_mensagem", "ID Chat");
            dataGridViewMensagens.Columns.Add("nome_usuario", "Nome do Usuário");
            dataGridViewMensagens.Columns.Add("texto_mensagem", "Texto");
            dataGridViewMensagens.Columns.Add("data_mensagem", "Data");
            dataGridViewMensagens.Columns.Add("status_mensagem", "Status");

            // Defina propriedades adicionais, se necessário
            dataGridViewMensagens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMensagens.ReadOnly = true;
        }

        private void btoenviar_Click(object sender, EventArgs e)
        {
            EnviarMensagem();
            CarregarMensagens(); // Após enviar uma mensagem, recarrega as mensagens
        }

        private void EnviarMensagem()
        {
            if (cboUsuario1.SelectedValue == null || cboUsuario2.SelectedValue == null)
            {
                MessageBox.Show("Selecione usuários válidos antes de enviar a mensagem.");
                return;
            }

            int idUsuario1 = (int)cboUsuario1.SelectedValue;
            int idUsuario2 = (int)cboUsuario2.SelectedValue;
            string mensagem = txtmensagemUsuario2.Text;

            try
            {
                bool enviado = mensagemDAO.EnviarMensagem(idUsuario1, idUsuario2, mensagem);

                if (enviado)
                {
                    MessageBox.Show("Mensagem enviada com sucesso!");
                    txtmensagemUsuario2.Text = "";
                }
                else
                {
                    MessageBox.Show("Erro ao enviar mensagem.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar mensagem: " + ex.Message);
            }
        }

        private void btoatualizar_Click(object sender, EventArgs e)
        {
            MarcarMensagensComoLidas();
            CarregarMensagens(); // Recarrega as mensagens após marcar como lidas
        }

        private void MarcarMensagensComoLidas()
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(stringConexao))
                {
                    string sql = "UPDATE mensagem SET status_mensagem = 1 WHERE status_mensagem = 0";

                    using (SqlCommand cmd = new SqlCommand(sql, conexao))
                    {
                        conexao.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao marcar mensagens como lidas: " + ex.Message);
            }
        }

        // Adicione o método para carregar mensagens
        private void CarregarMensagens()
        {
            try
            {
                // Certifique-se de limpar as linhas existentes
                dataGridViewMensagens.Rows.Clear();

                using (SqlConnection conexao = new SqlConnection(stringConexao))
                {
                    string sql = "SELECT m.id_chat_mensagem, u.nome_usuario, m.texto_mensagem, m.data_mensagem, m.status_mensagem " +
                                 "FROM mensagem m " +
                                 "INNER JOIN usuario u ON m.id_usuario_mensagem = u.id_usuario " +
                                 "ORDER BY m.data_mensagem DESC";

                    SqlCommand cmd = new SqlCommand(sql, conexao);
                    conexao.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int idChat = Convert.ToInt32(reader["id_chat_mensagem"]);
                        string nomeUsuario = reader["nome_usuario"].ToString();
                        string texto = reader["texto_mensagem"].ToString();
                        DateTime data = Convert.ToDateTime(reader["data_mensagem"]);
                        bool status = Convert.ToBoolean(reader["status_mensagem"]); // Converta para bool

                        dataGridViewMensagens.Rows.Add(idChat, nomeUsuario, texto, data, status);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar mensagens: " + ex.Message);
            }
        }
    }
}
