namespace O_Projeto
{
    partial class Inicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicial));
            this.Login = new MetroFramework.Controls.MetroButton();
            this.Cadastro = new MetroFramework.Controls.MetroButton();
            this.Sair = new MetroFramework.Controls.MetroButton();
            this.roundPictureBox1 = new O_Projeto.RoundPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Login.Location = new System.Drawing.Point(109, 168);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(181, 76);
            this.Login.TabIndex = 2;
            this.Login.Text = "Login";
            this.Login.UseSelectable = true;
            this.Login.UseVisualStyleBackColor = false;
            // 
            // Cadastro
            // 
            this.Cadastro.Location = new System.Drawing.Point(109, 250);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(181, 76);
            this.Cadastro.TabIndex = 3;
            this.Cadastro.Text = "Cadastro";
            this.Cadastro.UseSelectable = true;
            // 
            // Sair
            // 
            this.Sair.Location = new System.Drawing.Point(109, 332);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(181, 76);
            this.Sair.TabIndex = 4;
            this.Sair.Text = "Sair";
            this.Sair.UseSelectable = true;
            // 
            // roundPictureBox1
            // 
            this.roundPictureBox1.Image = global::O_Projeto.Properties.Resources.crie_um_icone_com_o_nome_collabopro__1_;
            this.roundPictureBox1.Location = new System.Drawing.Point(12, 12);
            this.roundPictureBox1.Name = "roundPictureBox1";
            this.roundPictureBox1.Size = new System.Drawing.Size(100, 100);
            this.roundPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.roundPictureBox1.TabIndex = 5;
            this.roundPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(122, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bem-Vindo!!!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(118, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 44);
            this.label2.TabIndex = 7;
            this.label2.Text = "Esse é um Software \r\nde Gestão de Projetos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::O_Projeto.Properties.Resources._1a7dfbdcc96200cfa682a193f8e156b0;
            this.ClientSize = new System.Drawing.Size(397, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roundPictureBox1);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.Cadastro);
            this.Controls.Add(this.Login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicial";
            this.Text = "Inicial";
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton Login;
        private MetroFramework.Controls.MetroButton Cadastro;
        private MetroFramework.Controls.MetroButton Sair;
        private RoundPictureBox roundPictureBox1;
        private Label label1;
        private Label label2;
    }
}