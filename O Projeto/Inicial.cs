

namespace O_Projeto
{
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            frmlogin login = new frmlogin();
            login.ShowDialog();
            this.Hide();
        }

        private void Cadastro_Click(object sender, EventArgs e)
        {
            Frmcadastro Cadastro = new Frmcadastro();
            Cadastro.ShowDialog();
            this.Hide();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}