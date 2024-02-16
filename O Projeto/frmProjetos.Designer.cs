namespace O_Projeto
{
    partial class frmProjeto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjeto));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btoEditar = new System.Windows.Forms.Button();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.txtRecursos = new System.Windows.Forms.TextBox();
            this.txtOrc = new System.Windows.Forms.TextBox();
            this.txtRiscos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtResumo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomeProjeto = new System.Windows.Forms.TextBox();
            this.txtDataInicio = new System.Windows.Forms.MaskedTextBox();
            this.txtDataTermino = new System.Windows.Forms.MaskedTextBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btoExcluir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btoAdicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btoTarefa = new System.Windows.Forms.Button();
            this.btoCalendario = new System.Windows.Forms.Button();
            this.btoProjetos = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btoChat = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.btoEditar);
            this.groupBox2.Controls.Add(this.cboCategoria);
            this.groupBox2.Controls.Add(this.txtRecursos);
            this.groupBox2.Controls.Add(this.txtOrc);
            this.groupBox2.Controls.Add(this.txtRiscos);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtResumo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtNomeProjeto);
            this.groupBox2.Controls.Add(this.txtDataInicio);
            this.groupBox2.Controls.Add(this.txtDataTermino);
            this.groupBox2.Controls.Add(this.cboStatus);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btoExcluir);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btoAdicionar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(203, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(562, 436);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // btoEditar
            // 
            this.btoEditar.BackColor = System.Drawing.Color.Red;
            this.btoEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btoEditar.Location = new System.Drawing.Point(474, 22);
            this.btoEditar.Name = "btoEditar";
            this.btoEditar.Size = new System.Drawing.Size(82, 22);
            this.btoEditar.TabIndex = 42;
            this.btoEditar.Text = "&Editar";
            this.btoEditar.UseVisualStyleBackColor = false;
            this.btoEditar.Click += new System.EventHandler(this.btoEditar_Click);
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Items.AddRange(new object[] {
            "Tecnologia",
            "Administração",
            "Recursos Humanos",
            "Arquitetura"});
            this.cboCategoria.Location = new System.Drawing.Point(18, 145);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(234, 23);
            this.cboCategoria.TabIndex = 41;
            // 
            // txtRecursos
            // 
            this.txtRecursos.Location = new System.Drawing.Point(290, 342);
            this.txtRecursos.Name = "txtRecursos";
            this.txtRecursos.Size = new System.Drawing.Size(233, 23);
            this.txtRecursos.TabIndex = 40;
            // 
            // txtOrc
            // 
            this.txtOrc.Location = new System.Drawing.Point(290, 268);
            this.txtOrc.Name = "txtOrc";
            this.txtOrc.Size = new System.Drawing.Size(233, 23);
            this.txtOrc.TabIndex = 39;
            // 
            // txtRiscos
            // 
            this.txtRiscos.Location = new System.Drawing.Point(290, 208);
            this.txtRiscos.Name = "txtRiscos";
            this.txtRiscos.Size = new System.Drawing.Size(233, 23);
            this.txtRiscos.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(290, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 15);
            this.label9.TabIndex = 37;
            this.label9.Text = "Recursos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(290, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 36;
            this.label8.Text = "Orçamento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(290, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 35;
            this.label7.Text = "Riscos";
            // 
            // txtResumo
            // 
            this.txtResumo.Location = new System.Drawing.Point(290, 70);
            this.txtResumo.Multiline = true;
            this.txtResumo.Name = "txtResumo";
            this.txtResumo.Size = new System.Drawing.Size(233, 98);
            this.txtResumo.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(290, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "Resumo dos objetivos";
            // 
            // txtNomeProjeto
            // 
            this.txtNomeProjeto.Location = new System.Drawing.Point(20, 72);
            this.txtNomeProjeto.Name = "txtNomeProjeto";
            this.txtNomeProjeto.Size = new System.Drawing.Size(233, 23);
            this.txtNomeProjeto.TabIndex = 29;
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.Location = new System.Drawing.Point(19, 208);
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.Size = new System.Drawing.Size(234, 23);
            this.txtDataInicio.TabIndex = 27;
            // 
            // txtDataTermino
            // 
            this.txtDataTermino.Location = new System.Drawing.Point(18, 268);
            this.txtDataTermino.Name = "txtDataTermino";
            this.txtDataTermino.Size = new System.Drawing.Size(233, 23);
            this.txtDataTermino.TabIndex = 26;
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "ALTA",
            "MÉDIA",
            "BAIXA"});
            this.cboStatus.Location = new System.Drawing.Point(19, 342);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(234, 23);
            this.cboStatus.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(19, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Prioridade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(18, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Data de Término";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(18, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Data de Início";
            // 
            // btoExcluir
            // 
            this.btoExcluir.AutoSize = true;
            this.btoExcluir.BackColor = System.Drawing.Color.Red;
            this.btoExcluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btoExcluir.Location = new System.Drawing.Point(430, 383);
            this.btoExcluir.Name = "btoExcluir";
            this.btoExcluir.Size = new System.Drawing.Size(93, 37);
            this.btoExcluir.TabIndex = 21;
            this.btoExcluir.Text = "&Excluir";
            this.btoExcluir.UseVisualStyleBackColor = false;
            this.btoExcluir.Click += new System.EventHandler(this.btoExcluir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(18, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Categoria";
            // 
            // btoAdicionar
            // 
            this.btoAdicionar.BackColor = System.Drawing.Color.Sienna;
            this.btoAdicionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btoAdicionar.Location = new System.Drawing.Point(18, 384);
            this.btoAdicionar.Name = "btoAdicionar";
            this.btoAdicionar.Size = new System.Drawing.Size(94, 35);
            this.btoAdicionar.TabIndex = 20;
            this.btoAdicionar.Text = "&Adicionar";
            this.btoAdicionar.UseVisualStyleBackColor = false;
            this.btoAdicionar.Click += new System.EventHandler(this.btoAdicionar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(20, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Projeto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(409, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 30);
            this.label10.TabIndex = 25;
            this.label10.Text = "Projeto";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.btoTarefa);
            this.groupBox1.Controls.Add(this.btoCalendario);
            this.groupBox1.Controls.Add(this.btoProjetos);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btoChat);
            this.groupBox1.ForeColor = System.Drawing.Color.Sienna;
            this.groupBox1.Location = new System.Drawing.Point(-2, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 538);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // btoTarefa
            // 
            this.btoTarefa.AllowDrop = true;
            this.btoTarefa.AutoEllipsis = true;
            this.btoTarefa.BackColor = System.Drawing.Color.Silver;
            this.btoTarefa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btoTarefa.Image = ((System.Drawing.Image)(resources.GetObject("btoTarefa.Image")));
            this.btoTarefa.Location = new System.Drawing.Point(22, 287);
            this.btoTarefa.Name = "btoTarefa";
            this.btoTarefa.Size = new System.Drawing.Size(73, 68);
            this.btoTarefa.TabIndex = 4;
            this.btoTarefa.UseVisualStyleBackColor = false;
            this.btoTarefa.Click += new System.EventHandler(this.btoTarefa_Click);
            // 
            // btoCalendario
            // 
            this.btoCalendario.AllowDrop = true;
            this.btoCalendario.AutoEllipsis = true;
            this.btoCalendario.BackColor = System.Drawing.Color.Silver;
            this.btoCalendario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btoCalendario.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btoCalendario.Image = ((System.Drawing.Image)(resources.GetObject("btoCalendario.Image")));
            this.btoCalendario.Location = new System.Drawing.Point(22, 393);
            this.btoCalendario.Name = "btoCalendario";
            this.btoCalendario.Size = new System.Drawing.Size(73, 77);
            this.btoCalendario.TabIndex = 3;
            this.btoCalendario.UseVisualStyleBackColor = false;
            this.btoCalendario.Click += new System.EventHandler(this.btoCalendario_Click);
            // 
            // btoProjetos
            // 
            this.btoProjetos.AllowDrop = true;
            this.btoProjetos.AutoEllipsis = true;
            this.btoProjetos.BackColor = System.Drawing.Color.Silver;
            this.btoProjetos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btoProjetos.Image = ((System.Drawing.Image)(resources.GetObject("btoProjetos.Image")));
            this.btoProjetos.Location = new System.Drawing.Point(22, 198);
            this.btoProjetos.Name = "btoProjetos";
            this.btoProjetos.Size = new System.Drawing.Size(73, 69);
            this.btoProjetos.TabIndex = 2;
            this.btoProjetos.UseVisualStyleBackColor = false;
            this.btoProjetos.Click += new System.EventHandler(this.btoProjetos_Click);
            // 
            // button3
            // 
            this.button3.AllowDrop = true;
            this.button3.AutoEllipsis = true;
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(22, 108);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 66);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btoChat
            // 
            this.btoChat.AllowDrop = true;
            this.btoChat.AutoEllipsis = true;
            this.btoChat.BackColor = System.Drawing.Color.Silver;
            this.btoChat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btoChat.Image = ((System.Drawing.Image)(resources.GetObject("btoChat.Image")));
            this.btoChat.Location = new System.Drawing.Point(22, 22);
            this.btoChat.Name = "btoChat";
            this.btoChat.Size = new System.Drawing.Size(73, 63);
            this.btoChat.TabIndex = 0;
            this.btoChat.UseMnemonic = false;
            this.btoChat.UseVisualStyleBackColor = false;
            this.btoChat.UseWaitCursor = true;
            this.btoChat.Click += new System.EventHandler(this.btoChat_Click);
            // 
            // frmProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(833, 527);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "frmProjeto";
            this.Text = "Editar Projeto";
            this.Load += new System.EventHandler(this.frmCriarProjeto_Load_1);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox groupBox2;
        private TextBox txtNomeProjeto;
        private MaskedTextBox txtDataInicio;
        private MaskedTextBox txtDataTermino;
        private ComboBox cboStatus;
        private Label label5;
        private Label label4;
        private Label label2;
        private Button btoExcluir;
        private Label label3;
        private Button btoAdicionar;
        private Label label1;
        private Label label7;
        private TextBox txtResumo;
        private Label label6;
        private TextBox txtRecursos;
        private TextBox txtOrc;
        private TextBox txtRiscos;
        private Label label9;
        private Label label8;
        private Label label10;
        private GroupBox groupBox1;
        private Button btoTarefa;
        private Button btoCalendario;
        private Button btoProjetos;
        private Button button3;
        private Button btoChat;
        private ComboBox cboCategoria;
        private Button btoEditar;

    }
}