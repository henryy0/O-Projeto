namespace O_Projeto
{
    partial class frmEdicao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Adicionando controles
        private Label lblNome;
        private TextBox txtNome;
        private Label lblTipo;
        private TextBox txtTipo;
        private Label lblDataInicio;
        private DateTimePicker dtpDataInicio;
        private Label lblDataFim;
        private DateTimePicker dtpDataFim;
        private Label lblStatus;
        private TextBox txtStatus;
        private Label lblResumo;
        private TextBox txtResumo;
        private Label lblRiscos;
        private TextBox txtRiscos;
        private Label lblOrcamento;
        private TextBox txtOrcamento;
        private Label lblRecursos;
        private TextBox txtRecursos;
        private Button btnSalvar;
        private Button btnCancelar;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.lblDataFim = new System.Windows.Forms.Label();
            this.dtpDataFim = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblResumo = new System.Windows.Forms.Label();
            this.txtResumo = new System.Windows.Forms.TextBox();
            this.lblRiscos = new System.Windows.Forms.Label();
            this.txtRiscos = new System.Windows.Forms.TextBox();
            this.lblOrcamento = new System.Windows.Forms.Label();
            this.txtOrcamento = new System.Windows.Forms.TextBox();
            this.lblRecursos = new System.Windows.Forms.Label();
            this.txtRecursos = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.Location = new System.Drawing.Point(10, 10);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(100, 23);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome do Projeto:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(150, 10);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 23);
            this.txtNome.TabIndex = 1;
            // 
            // lblTipo
            // 
            this.lblTipo.Location = new System.Drawing.Point(10, 40);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(100, 23);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo do Projeto:";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(150, 40);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(200, 23);
            this.txtTipo.TabIndex = 3;
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.Location = new System.Drawing.Point(10, 70);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(100, 23);
            this.lblDataInicio.TabIndex = 4;
            this.lblDataInicio.Text = "Data de Início:";
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.Location = new System.Drawing.Point(150, 70);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.Size = new System.Drawing.Size(200, 23);
            this.dtpDataInicio.TabIndex = 5;
            // 
            // lblDataFim
            // 
            this.lblDataFim.Location = new System.Drawing.Point(10, 100);
            this.lblDataFim.Name = "lblDataFim";
            this.lblDataFim.Size = new System.Drawing.Size(100, 23);
            this.lblDataFim.TabIndex = 6;
            this.lblDataFim.Text = "Data de Término:";
            // 
            // dtpDataFim
            // 
            this.dtpDataFim.Location = new System.Drawing.Point(150, 100);
            this.dtpDataFim.Name = "dtpDataFim";
            this.dtpDataFim.Size = new System.Drawing.Size(200, 23);
            this.dtpDataFim.TabIndex = 7;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(10, 130);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 23);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status do Projeto:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(150, 130);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(200, 23);
            this.txtStatus.TabIndex = 9;
            // 
            // lblResumo
            // 
            this.lblResumo.Location = new System.Drawing.Point(10, 160);
            this.lblResumo.Name = "lblResumo";
            this.lblResumo.Size = new System.Drawing.Size(100, 23);
            this.lblResumo.TabIndex = 10;
            this.lblResumo.Text = "Resumo do Projeto:";
            // 
            // txtResumo
            // 
            this.txtResumo.Location = new System.Drawing.Point(150, 160);
            this.txtResumo.Multiline = true;
            this.txtResumo.Name = "txtResumo";
            this.txtResumo.Size = new System.Drawing.Size(200, 60);
            this.txtResumo.TabIndex = 11;
            // 
            // lblRiscos
            // 
            this.lblRiscos.Location = new System.Drawing.Point(10, 230);
            this.lblRiscos.Name = "lblRiscos";
            this.lblRiscos.Size = new System.Drawing.Size(100, 23);
            this.lblRiscos.TabIndex = 12;
            this.lblRiscos.Text = "Riscos do Projeto:";
            // 
            // txtRiscos
            // 
            this.txtRiscos.Location = new System.Drawing.Point(150, 230);
            this.txtRiscos.Multiline = true;
            this.txtRiscos.Name = "txtRiscos";
            this.txtRiscos.Size = new System.Drawing.Size(200, 40);
            this.txtRiscos.TabIndex = 13;
            // 
            // lblOrcamento
            // 
            this.lblOrcamento.Location = new System.Drawing.Point(10, 280);
            this.lblOrcamento.Name = "lblOrcamento";
            this.lblOrcamento.Size = new System.Drawing.Size(100, 23);
            this.lblOrcamento.TabIndex = 14;
            this.lblOrcamento.Text = "Orçamento do Projeto:";
            // 
            // txtOrcamento
            // 
            this.txtOrcamento.Location = new System.Drawing.Point(150, 280);
            this.txtOrcamento.Name = "txtOrcamento";
            this.txtOrcamento.Size = new System.Drawing.Size(200, 23);
            this.txtOrcamento.TabIndex = 15;
            // 
            // lblRecursos
            // 
            this.lblRecursos.Location = new System.Drawing.Point(10, 310);
            this.lblRecursos.Name = "lblRecursos";
            this.lblRecursos.Size = new System.Drawing.Size(100, 23);
            this.lblRecursos.TabIndex = 16;
            this.lblRecursos.Text = "Recursos do Projeto:";
            // 
            // txtRecursos
            // 
            this.txtRecursos.Location = new System.Drawing.Point(150, 310);
            this.txtRecursos.Name = "txtRecursos";
            this.txtRecursos.Size = new System.Drawing.Size(200, 23);
            this.txtRecursos.TabIndex = 17;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(10, 350);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 18;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(90, 350);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmEdicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 387);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.lblDataInicio);
            this.Controls.Add(this.dtpDataInicio);
            this.Controls.Add(this.lblDataFim);
            this.Controls.Add(this.dtpDataFim);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblResumo);
            this.Controls.Add(this.txtResumo);
            this.Controls.Add(this.lblRiscos);
            this.Controls.Add(this.txtRiscos);
            this.Controls.Add(this.lblOrcamento);
            this.Controls.Add(this.txtOrcamento);
            this.Controls.Add(this.lblRecursos);
            this.Controls.Add(this.txtRecursos);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Name = "frmEdicao";
            this.Text = "frmEdicao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

    }
}
