namespace O_Projeto
{
    partial class frmNovaEquipe
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblNomeEquipe = new System.Windows.Forms.Label();
            this.txtNomeEquipe = new System.Windows.Forms.TextBox();
            this.lblDescricaoEquipe = new System.Windows.Forms.Label();
            this.txtDescricaoEquipe = new System.Windows.Forms.TextBox();
            this.lblProjetoAtribuidoID = new System.Windows.Forms.Label();
            this.txtProjetoAtribuidoID = new System.Windows.Forms.TextBox();
            this.lblLiderEquipe = new System.Windows.Forms.Label();
            this.cboLider = new System.Windows.Forms.ComboBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomeEquipe
            // 
            this.lblNomeEquipe.AutoSize = true;
            this.lblNomeEquipe.Location = new System.Drawing.Point(14, 17);
            this.lblNomeEquipe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeEquipe.Name = "lblNomeEquipe";
            this.lblNomeEquipe.Size = new System.Drawing.Size(98, 15);
            this.lblNomeEquipe.TabIndex = 0;
            this.lblNomeEquipe.Text = "Nome da Equipe:";
            // 
            // txtNomeEquipe
            // 
            this.txtNomeEquipe.Location = new System.Drawing.Point(117, 14);
            this.txtNomeEquipe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNomeEquipe.Name = "txtNomeEquipe";
            this.txtNomeEquipe.Size = new System.Drawing.Size(233, 23);
            this.txtNomeEquipe.TabIndex = 1;
            // 
            // lblDescricaoEquipe
            // 
            this.lblDescricaoEquipe.AutoSize = true;
            this.lblDescricaoEquipe.Location = new System.Drawing.Point(14, 52);
            this.lblDescricaoEquipe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricaoEquipe.Name = "lblDescricaoEquipe";
            this.lblDescricaoEquipe.Size = new System.Drawing.Size(116, 15);
            this.lblDescricaoEquipe.TabIndex = 2;
            this.lblDescricaoEquipe.Text = "Descrição da Equipe:";
            // 
            // txtDescricaoEquipe
            // 
            this.txtDescricaoEquipe.Location = new System.Drawing.Point(140, 48);
            this.txtDescricaoEquipe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescricaoEquipe.Multiline = true;
            this.txtDescricaoEquipe.Name = "txtDescricaoEquipe";
            this.txtDescricaoEquipe.Size = new System.Drawing.Size(209, 69);
            this.txtDescricaoEquipe.TabIndex = 3;
            // 
            // lblProjetoAtribuidoID
            // 
            this.lblProjetoAtribuidoID.AutoSize = true;
            this.lblProjetoAtribuidoID.Location = new System.Drawing.Point(14, 138);
            this.lblProjetoAtribuidoID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProjetoAtribuidoID.Name = "lblProjetoAtribuidoID";
            this.lblProjetoAtribuidoID.Size = new System.Drawing.Size(115, 15);
            this.lblProjetoAtribuidoID.TabIndex = 4;
            this.lblProjetoAtribuidoID.Text = "Projeto Atribuído ID:";
            // 
            // txtProjetoAtribuidoID
            // 
            this.txtProjetoAtribuidoID.Location = new System.Drawing.Point(148, 135);
            this.txtProjetoAtribuidoID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtProjetoAtribuidoID.Name = "txtProjetoAtribuidoID";
            this.txtProjetoAtribuidoID.Size = new System.Drawing.Size(116, 23);
            this.txtProjetoAtribuidoID.TabIndex = 5;
            // 
            // lblLiderEquipe
            // 
            this.lblLiderEquipe.AutoSize = true;
            this.lblLiderEquipe.Location = new System.Drawing.Point(14, 173);
            this.lblLiderEquipe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLiderEquipe.Name = "lblLiderEquipe";
            this.lblLiderEquipe.Size = new System.Drawing.Size(91, 15);
            this.lblLiderEquipe.TabIndex = 8;
            this.lblLiderEquipe.Text = "Líder da Equipe:";
            // 
            // cboLider
            // 
            this.cboLider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLider.FormattingEnabled = true;
            this.cboLider.Location = new System.Drawing.Point(117, 170);
            this.cboLider.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboLider.Name = "cboLider";
            this.cboLider.Size = new System.Drawing.Size(233, 23);
            this.cboLider.TabIndex = 9;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(14, 219);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(105, 35);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(140, 219);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 35);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmNovaEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 265);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.cboLider);
            this.Controls.Add(this.lblLiderEquipe);
            this.Controls.Add(this.txtProjetoAtribuidoID);
            this.Controls.Add(this.lblProjetoAtribuidoID);
            this.Controls.Add(this.txtDescricaoEquipe);
            this.Controls.Add(this.lblDescricaoEquipe);
            this.Controls.Add(this.txtNomeEquipe);
            this.Controls.Add(this.lblNomeEquipe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNovaEquipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nova Equipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblNomeEquipe;
        private System.Windows.Forms.TextBox txtNomeEquipe;
        private System.Windows.Forms.Label lblDescricaoEquipe;
        private System.Windows.Forms.TextBox txtDescricaoEquipe;
        private System.Windows.Forms.Label lblProjetoAtribuidoID;
        private System.Windows.Forms.TextBox txtProjetoAtribuidoID;
        private System.Windows.Forms.Label lblLiderEquipe;
        private System.Windows.Forms.ComboBox cboLider;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
