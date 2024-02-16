using System;
using System.Windows.Forms;

namespace O_Projeto
{
    partial class frmChat2 : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChat2));
            this.btoatualizar = new System.Windows.Forms.Button();
            this.btoenviar = new System.Windows.Forms.Button();
            this.txtmensagemUsuario2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboUsuario1 = new System.Windows.Forms.ComboBox();
            this.cboUsuario2 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btoTarefa = new System.Windows.Forms.Button();
            this.btoCalendario = new System.Windows.Forms.Button();
            this.btoProjetos = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btoChat = new System.Windows.Forms.Button();
            this.dataGridViewMensagens = new System.Windows.Forms.DataGridView();
            this.dataGridMensagem = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMensagens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMensagem)).BeginInit();
            this.SuspendLayout();
            // 
            // btoatualizar
            // 
            this.btoatualizar.Location = new System.Drawing.Point(352, 406);
            this.btoatualizar.Name = "btoatualizar";
            this.btoatualizar.Size = new System.Drawing.Size(77, 30);
            this.btoatualizar.TabIndex = 0;
            this.btoatualizar.Text = "atualizar";
            this.btoatualizar.UseVisualStyleBackColor = true;
            this.btoatualizar.Click += new System.EventHandler(this.btoatualizar_Click);
            // 
            // btoenviar
            // 
            this.btoenviar.Location = new System.Drawing.Point(435, 406);
            this.btoenviar.Name = "btoenviar";
            this.btoenviar.Size = new System.Drawing.Size(77, 30);
            this.btoenviar.TabIndex = 0;
            this.btoenviar.Text = "enviar ";
            this.btoenviar.UseVisualStyleBackColor = true;
            this.btoenviar.Click += new System.EventHandler(this.btoenviar_Click);
            // 
            // txtmensagemUsuario2
            // 
            this.txtmensagemUsuario2.Location = new System.Drawing.Point(149, 215);
            this.txtmensagemUsuario2.Multiline = true;
            this.txtmensagemUsuario2.Name = "txtmensagemUsuario2";
            this.txtmensagemUsuario2.Size = new System.Drawing.Size(363, 131);
            this.txtmensagemUsuario2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "mensagem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "usuario1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "usuario2";
            // 
            // cboUsuario1
            // 
            this.cboUsuario1.FormattingEnabled = true;
            this.cboUsuario1.Location = new System.Drawing.Point(149, 64);
            this.cboUsuario1.Name = "cboUsuario1";
            this.cboUsuario1.Size = new System.Drawing.Size(363, 23);
            this.cboUsuario1.TabIndex = 3;
            // 
            // cboUsuario2
            // 
            this.cboUsuario2.FormattingEnabled = true;
            this.cboUsuario2.Location = new System.Drawing.Point(149, 144);
            this.cboUsuario2.Name = "cboUsuario2";
            this.cboUsuario2.Size = new System.Drawing.Size(363, 23);
            this.cboUsuario2.TabIndex = 4;
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
            this.groupBox1.Location = new System.Drawing.Point(1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 538);
            this.groupBox1.TabIndex = 28;
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
            // 
            // dataGridViewMensagens
            // 
            this.dataGridViewMensagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMensagens.Location = new System.Drawing.Point(531, 259);
            this.dataGridViewMensagens.Name = "dataGridViewMensagens";
            this.dataGridViewMensagens.RowTemplate.Height = 25;
            this.dataGridViewMensagens.Size = new System.Drawing.Size(363, 177);
            this.dataGridViewMensagens.TabIndex = 29;
            // 
            // dataGridMensagem
            // 
            this.dataGridMensagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMensagem.Location = new System.Drawing.Point(531, 64);
            this.dataGridMensagem.Name = "dataGridMensagem";
            this.dataGridMensagem.RowTemplate.Height = 25;
            this.dataGridMensagem.Size = new System.Drawing.Size(363, 177);
            this.dataGridMensagem.TabIndex = 32;
            // 
            // frmChat2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 478);
            this.Controls.Add(this.dataGridMensagem);
            this.Controls.Add(this.dataGridViewMensagens);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboUsuario2);
            this.Controls.Add(this.cboUsuario1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmensagemUsuario2);
            this.Controls.Add(this.btoenviar);
            this.Controls.Add(this.btoatualizar);
            this.Name = "frmChat2";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMensagens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMensagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btoatualizar;
        private Button btoenviar;
        private TextBox txtmensagemUsuario2;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cboUsuario1;
        private ComboBox cboUsuario2;
        private GroupBox groupBox1;
        private Button btoTarefa;
        private Button btoCalendario;
        private Button btoProjetos;
        private Button button3;
        private Button btoChat;
        private DataGridView dataGridViewMensagens;
        private DataGridView dataGridMensagem;
    }
}