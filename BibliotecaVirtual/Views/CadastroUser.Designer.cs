namespace BibliotecaVirtual.Views
{
    partial class CadastroUser
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtWarningNome = new System.Windows.Forms.Label();
            this.txtWarningSenha = new System.Windows.Forms.Label();
            this.txtWarningEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtWarningConfirm = new System.Windows.Forms.Label();
            this.txtConfirSenha = new System.Windows.Forms.TextBox();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTitulo
            // 
            this.txtTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(6, 39);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(214, 33);
            this.txtTitulo.TabIndex = 4;
            this.txtTitulo.Text = "Cadastra - se";
            this.txtTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome do Usuario";
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(55, 180);
            this.txtNome.Margin = new System.Windows.Forms.Padding(6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(260, 26);
            this.txtNome.TabIndex = 6;
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(55, 258);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(6);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(260, 26);
            this.txtSenha.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCadastrar.AutoSize = true;
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(325, 416);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(114, 37);
            this.btnCadastrar.TabIndex = 13;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtWarningNome
            // 
            this.txtWarningNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtWarningNome.AutoSize = true;
            this.txtWarningNome.ForeColor = System.Drawing.Color.Red;
            this.txtWarningNome.Location = new System.Drawing.Point(52, 212);
            this.txtWarningNome.Name = "txtWarningNome";
            this.txtWarningNome.Size = new System.Drawing.Size(139, 13);
            this.txtWarningNome.TabIndex = 14;
            this.txtWarningNome.Text = "Usuario ou senha incorretos";
            this.txtWarningNome.Visible = false;
            // 
            // txtWarningSenha
            // 
            this.txtWarningSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtWarningSenha.AutoSize = true;
            this.txtWarningSenha.ForeColor = System.Drawing.Color.Red;
            this.txtWarningSenha.Location = new System.Drawing.Point(52, 290);
            this.txtWarningSenha.Name = "txtWarningSenha";
            this.txtWarningSenha.Size = new System.Drawing.Size(139, 13);
            this.txtWarningSenha.TabIndex = 15;
            this.txtWarningSenha.Text = "Usuario ou senha incorretos";
            this.txtWarningSenha.Visible = false;
            // 
            // txtWarningEmail
            // 
            this.txtWarningEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtWarningEmail.AutoSize = true;
            this.txtWarningEmail.ForeColor = System.Drawing.Color.Red;
            this.txtWarningEmail.Location = new System.Drawing.Point(424, 212);
            this.txtWarningEmail.Name = "txtWarningEmail";
            this.txtWarningEmail.Size = new System.Drawing.Size(139, 13);
            this.txtWarningEmail.TabIndex = 16;
            this.txtWarningEmail.Text = "Usuario ou senha incorretos";
            this.txtWarningEmail.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(427, 180);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(263, 26);
            this.txtEmail.TabIndex = 10;
            // 
            // txtWarningConfirm
            // 
            this.txtWarningConfirm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtWarningConfirm.AutoSize = true;
            this.txtWarningConfirm.ForeColor = System.Drawing.Color.Red;
            this.txtWarningConfirm.Location = new System.Drawing.Point(424, 290);
            this.txtWarningConfirm.Name = "txtWarningConfirm";
            this.txtWarningConfirm.Size = new System.Drawing.Size(139, 13);
            this.txtWarningConfirm.TabIndex = 17;
            this.txtWarningConfirm.Text = "Usuario ou senha incorretos";
            this.txtWarningConfirm.Visible = false;
            // 
            // txtConfirSenha
            // 
            this.txtConfirSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirSenha.Location = new System.Drawing.Point(427, 258);
            this.txtConfirSenha.Margin = new System.Windows.Forms.Padding(6);
            this.txtConfirSenha.Name = "txtConfirSenha";
            this.txtConfirSenha.Size = new System.Drawing.Size(263, 26);
            this.txtConfirSenha.TabIndex = 12;
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Location = new System.Drawing.Point(424, 239);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(82, 13);
            this.lblConfirmarSenha.TabIndex = 11;
            this.lblConfirmarSenha.Text = "Confirma Senha";
            // 
            // CadastroUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(189)))), ((int)(((byte)(142)))));
            this.ClientSize = new System.Drawing.Size(832, 536);
            this.Controls.Add(this.txtWarningConfirm);
            this.Controls.Add(this.txtWarningEmail);
            this.Controls.Add(this.txtWarningSenha);
            this.Controls.Add(this.txtWarningNome);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtConfirSenha);
            this.Controls.Add(this.lblConfirmarSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitulo);
            this.Name = "CadastroUser";
            this.Text = "CadastroUser";
            this.Load += new System.EventHandler(this.CadastroUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label txtWarningNome;
        private System.Windows.Forms.Label txtWarningSenha;
        private System.Windows.Forms.Label txtWarningEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label txtWarningConfirm;
        private System.Windows.Forms.TextBox txtConfirSenha;
        private System.Windows.Forms.Label lblConfirmarSenha;
    }
}