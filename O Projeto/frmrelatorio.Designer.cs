namespace O_Projeto
{
    partial class frmrelatorio
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
            this.txtRecursos = new System.Windows.Forms.TextBox();
            this.txtRiscos = new System.Windows.Forms.TextBox();
            this.txtCronograma = new System.Windows.Forms.TextBox();
            this.txtOrçamento = new System.Windows.Forms.TextBox();
            this.txtResumo = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.labelResumo = new System.Windows.Forms.Label();
            this.dataGridRelatorio = new System.Windows.Forms.DataGridView();
            this.txtNomePesquisa = new System.Windows.Forms.TextBox();
            this.labelNomeProjeto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.botPesquisar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRelatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRecursos
            // 
            this.txtRecursos.Location = new System.Drawing.Point(12, 232);
            this.txtRecursos.Multiline = true;
            this.txtRecursos.Name = "txtRecursos";
            this.txtRecursos.Size = new System.Drawing.Size(984, 40);
            this.txtRecursos.TabIndex = 2;
            // 
            // txtRiscos
            // 
            this.txtRiscos.Location = new System.Drawing.Point(12, 82);
            this.txtRiscos.Multiline = true;
            this.txtRiscos.Name = "txtRiscos";
            this.txtRiscos.Size = new System.Drawing.Size(984, 40);
            this.txtRiscos.TabIndex = 2;
            // 
            // txtCronograma
            // 
            this.txtCronograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCronograma.Location = new System.Drawing.Point(12, 128);
            this.txtCronograma.Multiline = true;
            this.txtCronograma.Name = "txtCronograma";
            this.txtCronograma.Size = new System.Drawing.Size(984, 52);
            this.txtCronograma.TabIndex = 2;
            // 
            // txtOrçamento
            // 
            this.txtOrçamento.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOrçamento.Location = new System.Drawing.Point(12, 186);
            this.txtOrçamento.Multiline = true;
            this.txtOrçamento.Name = "txtOrçamento";
            this.txtOrçamento.Size = new System.Drawing.Size(984, 40);
            this.txtOrçamento.TabIndex = 2;
            // 
            // txtResumo
            // 
            this.txtResumo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResumo.Location = new System.Drawing.Point(12, 36);
            this.txtResumo.Multiline = true;
            this.txtResumo.Name = "txtResumo";
            this.txtResumo.Size = new System.Drawing.Size(984, 40);
            this.txtResumo.TabIndex = 2;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNome.ForeColor = System.Drawing.Color.DarkViolet;
            this.lbNome.Location = new System.Drawing.Point(62, -1);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(0, 19);
            this.lbNome.TabIndex = 4;
            // 
            // labelResumo
            // 
            this.labelResumo.AutoSize = true;
            this.labelResumo.ForeColor = System.Drawing.Color.BlueViolet;
            this.labelResumo.Location = new System.Drawing.Point(3, 18);
            this.labelResumo.Name = "labelResumo";
            this.labelResumo.Size = new System.Drawing.Size(0, 15);
            this.labelResumo.TabIndex = 5;
            this.labelResumo.Tag = "";
            // 
            // dataGridRelatorio
            // 
            this.dataGridRelatorio.ColumnHeadersHeight = 25;
            this.dataGridRelatorio.Location = new System.Drawing.Point(12, 323);
            this.dataGridRelatorio.Name = "dataGridRelatorio";
            this.dataGridRelatorio.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridRelatorio.RowTemplate.Height = 25;
            this.dataGridRelatorio.Size = new System.Drawing.Size(984, 163);
            this.dataGridRelatorio.TabIndex = 6;
            this.dataGridRelatorio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRelatorio_CellContentClick);
            // 
            // txtNomePesquisa
            // 
            this.txtNomePesquisa.Location = new System.Drawing.Point(12, 294);
            this.txtNomePesquisa.Name = "txtNomePesquisa";
            this.txtNomePesquisa.Size = new System.Drawing.Size(984, 23);
            this.txtNomePesquisa.TabIndex = 7;
            // 
            // labelNomeProjeto
            // 
            this.labelNomeProjeto.AutoSize = true;
            this.labelNomeProjeto.Location = new System.Drawing.Point(62, 3);
            this.labelNomeProjeto.Name = "labelNomeProjeto";
            this.labelNomeProjeto.Size = new System.Drawing.Size(0, 15);
            this.labelNomeProjeto.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "projeto";
            // 
            // botPesquisar
            // 
            this.botPesquisar.Location = new System.Drawing.Point(940, 7);
            this.botPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.botPesquisar.Name = "botPesquisar";
            this.botPesquisar.Size = new System.Drawing.Size(56, 24);
            this.botPesquisar.TabIndex = 9;
            this.botPesquisar.Text = "...";
            this.botPesquisar.UseVisualStyleBackColor = true;
            this.botPesquisar.Click += new System.EventHandler(this.botPesquisar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(858, 7);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(78, 23);
            this.txtCodigo.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(808, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Código";
            // 
            // frmrelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1001, 498);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.botPesquisar);
            this.Controls.Add(this.labelNomeProjeto);
            this.Controls.Add(this.txtNomePesquisa);
            this.Controls.Add(this.dataGridRelatorio);
            this.Controls.Add(this.labelResumo);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResumo);
            this.Controls.Add(this.txtOrçamento);
            this.Controls.Add(this.txtCronograma);
            this.Controls.Add(this.txtRiscos);
            this.Controls.Add(this.txtRecursos);
            this.Name = "frmrelatorio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmrelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRelatorio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtRecursos;
        private TextBox txtRiscos;
        private TextBox txtCronograma;
        private TextBox txtOrçamento;
        private TextBox txtResumo;
        private Label lbNome;
        private Label labelResumo;
        private DataGridView dataGridRelatorio;
        private TextBox txtNomePesquisa;
        private Label labelNomeProjeto;
        private Label label1;
        private Button botPesquisar;
        private TextBox txtCodigo;
        private Label label2;
    }
}