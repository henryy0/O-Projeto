using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace O_Projeto
{
    public partial class frmEdicao : Form
    {
        private string nomeProjeto;
        private string tipoProjeto;
        private DateTime dataInicioProjeto;
        private DateTime dataFimProjeto;
        private string statusProjeto;
        private string resumoProjeto;
        private string riscosProjeto;
        private int orcamentoProjeto;
        private string recursosProjeto;

        public frmEdicao()
        {
            InitializeComponent();
        }

        public string GetNomeProjeto() => txtNome.Text;
        public string GetTipoProjeto() => txtTipo.Text;
        public DateTime GetDataInicioProjeto() => dtpDataInicio.Value;
        public DateTime GetDataFimProjeto() => dtpDataFim.Value;
        public string GetStatusProjeto() => txtStatus.Text;
        public string GetResumoProjeto() => txtResumo.Text;
        public string GetRiscosProjeto() => txtRiscos.Text;
        public int GetOrcamentoProjeto() => int.Parse(txtOrcamento.Text);
        public string GetRecursosProjeto() => txtRecursos.Text;

        public bool SalvarAlteracoes { get; private set; }

        public void PreencherDadosProjeto(string nome, string tipo, DateTime inicio, DateTime fim, string status, string resumo, string riscos, int orcamento, string recursos)
        {
            nomeProjeto = nome;
            tipoProjeto = tipo;
            dataInicioProjeto = inicio;
            dataFimProjeto = fim;
            statusProjeto = status;
            resumoProjeto = resumo;
            riscosProjeto = riscos;
            orcamentoProjeto = orcamento;
            recursosProjeto = recursos;

            txtNome.Text = nome;
            txtTipo.Text = tipo;

            dtpDataInicio.Value = (inicio == DateTime.MinValue) ? DateTime.Today : inicio;
            dtpDataFim.Value = (fim == DateTime.MinValue) ? DateTime.Today : fim;

            txtStatus.Text = status;
            txtResumo.Text = resumo;
            txtRiscos.Text = riscos;
            txtOrcamento.Text = orcamento.ToString();
            txtRecursos.Text = recursos;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarAlteracoes = true;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            SalvarAlteracoes = false;
            this.Close();
        }
    }
}
