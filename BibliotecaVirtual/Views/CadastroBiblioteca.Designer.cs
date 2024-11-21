namespace BibliotecaVirtual.Views
{
    partial class CadastroBiblioteca
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
            this.txtTitulo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblWarningNome = new System.Windows.Forms.Label();
            this.lblWarningTelefone = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblWarningDescricao = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.btnCriarBiblio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTitulo
            // 
            this.txtTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(13, 27);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(309, 33);
            this.txtTitulo.TabIndex = 5;
            this.txtTitulo.Text = "Crie a sua biblioteca";
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(18, 157);
            this.txtNome.Margin = new System.Windows.Forms.Padding(6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(260, 26);
            this.txtNome.TabIndex = 7;
            // 
            // lblWarningNome
            // 
            this.lblWarningNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWarningNome.AutoSize = true;
            this.lblWarningNome.ForeColor = System.Drawing.Color.Red;
            this.lblWarningNome.Location = new System.Drawing.Point(16, 189);
            this.lblWarningNome.Name = "lblWarningNome";
            this.lblWarningNome.Size = new System.Drawing.Size(139, 13);
            this.lblWarningNome.TabIndex = 15;
            this.lblWarningNome.Text = "Usuario ou senha incorretos";
            this.lblWarningNome.Visible = false;
            // 
            // lblWarningTelefone
            // 
            this.lblWarningTelefone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWarningTelefone.AutoSize = true;
            this.lblWarningTelefone.ForeColor = System.Drawing.Color.Red;
            this.lblWarningTelefone.Location = new System.Drawing.Point(448, 180);
            this.lblWarningTelefone.Name = "lblWarningTelefone";
            this.lblWarningTelefone.Size = new System.Drawing.Size(139, 13);
            this.lblWarningTelefone.TabIndex = 16;
            this.lblWarningTelefone.Text = "Usuario ou senha incorretos";
            this.lblWarningTelefone.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome da biblioteca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(15, 260);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(6);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(260, 82);
            this.txtDescricao.TabIndex = 20;
            // 
            // lblWarningDescricao
            // 
            this.lblWarningDescricao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWarningDescricao.AutoSize = true;
            this.lblWarningDescricao.ForeColor = System.Drawing.Color.Red;
            this.lblWarningDescricao.Location = new System.Drawing.Point(16, 348);
            this.lblWarningDescricao.Name = "lblWarningDescricao";
            this.lblWarningDescricao.Size = new System.Drawing.Size(139, 13);
            this.lblWarningDescricao.TabIndex = 21;
            this.lblWarningDescricao.Text = "Usuario ou senha incorretos";
            this.lblWarningDescricao.Visible = false;
            this.lblWarningDescricao.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(450, 157);
            this.txtTelefone.Mask = "(99) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(260, 20);
            this.txtTelefone.TabIndex = 22;
            // 
            // btnCriarBiblio
            // 
            this.btnCriarBiblio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCriarBiblio.AutoSize = true;
            this.btnCriarBiblio.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnCriarBiblio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCriarBiblio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarBiblio.Location = new System.Drawing.Point(341, 431);
            this.btnCriarBiblio.Name = "btnCriarBiblio";
            this.btnCriarBiblio.Size = new System.Drawing.Size(114, 37);
            this.btnCriarBiblio.TabIndex = 23;
            this.btnCriarBiblio.Text = "Criar";
            this.btnCriarBiblio.UseVisualStyleBackColor = false;
            this.btnCriarBiblio.Click += new System.EventHandler(this.btnCriarBiblio_Click);
            // 
            // CadastroBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(189)))), ((int)(((byte)(142)))));
            this.ClientSize = new System.Drawing.Size(802, 526);
            this.Controls.Add(this.btnCriarBiblio);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblWarningDescricao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblWarningTelefone);
            this.Controls.Add(this.lblWarningNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CadastroBiblioteca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroBiblioteca";
            this.Load += new System.EventHandler(this.CadastroBiblioteca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblWarningNome;
        private System.Windows.Forms.Label lblWarningTelefone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblWarningDescricao;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Button btnCriarBiblio;
    }
}