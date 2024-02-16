using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace O_Projeto
{
    public partial class frmNovaEquipe : Form
    {
        private const string ConnectionString = "Data Source=localhost;Initial Catalog=sistemaDeGerenciamento;User ID=sa;Password=123456";

        public frmNovaEquipe()
        {
            InitializeComponent();

            // Carregue os usuários na ComboBox ao inicializar o formulário
            LoadUsuariosIntoComboBox();
        }

        private void LoadUsuariosIntoComboBox()
        {
            try
            {
                using (var conexao = new SqlConnection(ConnectionString))
                {
                    conexao.Open();

                    const string QuerySelectUsuarios = "SELECT id_usuario, nome_usuario FROM usuario";

                    using (var comandoSelectUsuarios = new SqlCommand(QuerySelectUsuarios, conexao))
                    {
                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter(comandoSelectUsuarios))
                        {
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);

                            // Set the ComboBox's DataSource and DisplayMember
                            cboLider.DataSource = dataTable;
                            cboLider.DisplayMember = "nome_usuario";
                            cboLider.ValueMember = "id_usuario";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao carregar os usuários. Detalhes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int GetLiderID()
        {
            if (cboLider.SelectedItem != null)
            {
                return Convert.ToInt32(cboLider.SelectedValue);
            }
            else
            {
                MessageBox.Show("Selecione um líder para a equipe.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }
        }

        public string GetNomeEquipe()
        {
            return txtNomeEquipe.Text;
        }

        public string GetDescricaoEquipe()
        {
            return txtDescricaoEquipe.Text;
        }

        public int GetProjetoAtribuidoID()
        {
            int projetoAtribuidoID;
            if (int.TryParse(txtProjetoAtribuidoID.Text, out projetoAtribuidoID))
            {
                return projetoAtribuidoID;
            }
            return -1;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
