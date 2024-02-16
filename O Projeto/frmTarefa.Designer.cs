namespace O_Projeto
{
    partial class frmTarefa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTarefa));
            this.btoAdicionar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboProjeto = new System.Windows.Forms.ComboBox();
            this.txtDataTermino = new System.Windows.Forms.MaskedTextBox();
            this.txtDataInicio = new System.Windows.Forms.MaskedTextBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.txtNomeTarefa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btoExcluir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            // btoAdicionar
            // 
            this.btoAdicionar.BackColor = System.Drawing.Color.Sienna;
            this.btoAdicionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btoAdicionar.Location = new System.Drawing.Point(26, 343);
            this.btoAdicionar.Name = "btoAdicionar";
            this.btoAdicionar.Size = new System.Drawing.Size(94, 35);
            this.btoAdicionar.TabIndex = 20;
            this.btoAdicionar.Text = "&Adicionar";
            this.btoAdicionar.UseVisualStyleBackColor = false;
            this.btoAdicionar.Click += new System.EventHandler(this.btoAdicionar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.txtObs);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cboProjeto);
            this.groupBox2.Controls.Add(this.txtDataTermino);
            this.groupBox2.Controls.Add(this.txtDataInicio);
            this.groupBox2.Controls.Add(this.cboStatus);
            this.groupBox2.Controls.Add(this.txtNomeTarefa);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btoExcluir);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btoAdicionar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(375, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 434);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(21, 294);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(233, 23);
            this.txtObs.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(21, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 39;
            this.label7.Text = "Observação";
            // 
            // cboProjeto
            // 
            this.cboProjeto.FormattingEnabled = true;
            this.cboProjeto.Location = new System.Drawing.Point(23, 68);
            this.cboProjeto.Name = "cboProjeto";
            this.cboProjeto.Size = new System.Drawing.Size(234, 23);
            this.cboProjeto.TabIndex = 37;
            // 
            // txtDataTermino
            // 
            this.txtDataTermino.Location = new System.Drawing.Point(21, 203);
            this.txtDataTermino.Name = "txtDataTermino";
            this.txtDataTermino.Size = new System.Drawing.Size(234, 23);
            this.txtDataTermino.TabIndex = 36;
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.Location = new System.Drawing.Point(22, 159);
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.Size = new System.Drawing.Size(234, 23);
            this.txtDataInicio.TabIndex = 35;
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Alta",
            "Media",
            "Baixa"});
            this.cboStatus.Location = new System.Drawing.Point(21, 252);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(234, 23);
            this.cboStatus.TabIndex = 34;
            // 
            // txtNomeTarefa
            // 
            this.txtNomeTarefa.Location = new System.Drawing.Point(23, 112);
            this.txtNomeTarefa.Name = "txtNomeTarefa";
            this.txtNomeTarefa.Size = new System.Drawing.Size(233, 23);
            this.txtNomeTarefa.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(21, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Prioridade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(21, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Data de Término";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(21, 138);
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
            this.btoExcluir.Location = new System.Drawing.Point(172, 341);
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
            this.label3.Location = new System.Drawing.Point(22, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome da Tarefa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(22, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha o Projeto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(451, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 30);
            this.label6.TabIndex = 24;
            this.label6.Text = "Criar Tarefa";
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
            this.groupBox1.Location = new System.Drawing.Point(1, -4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 542);
            this.groupBox1.TabIndex = 27;
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
            // frmTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(880, 502);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmTarefa";
            this.Text = "Criar_Tarefa";
            this.Load += new System.EventHandler(this.Criar_Tarefa_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btoAdicionar;
        private GroupBox groupBox2;
        private Button btoExcluir;
        private Label label3;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label6;
        private TextBox txtNomeTarefa;
        private ComboBox cboStatus;
        private MaskedTextBox txtDataTermino;
        private MaskedTextBox txtDataInicio;
        private GroupBox groupBox1;
        private Button btoTarefa;
        private Button btoCalendario;
        private Button btoProjetos;
        private Button button3;
        private Button btoChat;
        private ComboBox cboProjeto;
        private TextBox txtObs;
        private Label label7;
    }
}