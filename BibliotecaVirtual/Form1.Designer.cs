namespace BibliotecaVirtual
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtCadastrar = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.txtWarningForm = new System.Windows.Forms.Label();
            this.imgVerSenha = new System.Windows.Forms.PictureBox();
            this.imgEsconderSenha = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVerSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEsconderSenha)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(309, 303);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(321, 26);
            this.txtEmail.TabIndex = 0;
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(309, 358);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(321, 26);
            this.txtSenha.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(381, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "ClaudBook";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogin.AutoSize = true;
            this.btnLogin.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(409, 458);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(114, 37);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtCadastrar
            // 
            this.txtCadastrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCadastrar.AutoSize = true;
            this.txtCadastrar.Location = new System.Drawing.Point(306, 387);
            this.txtCadastrar.Name = "txtCadastrar";
            this.txtCadastrar.Size = new System.Drawing.Size(69, 13);
            this.txtCadastrar.TabIndex = 2;
            this.txtCadastrar.TabStop = true;
            this.txtCadastrar.Text = "Cadastra - se";
            this.txtCadastrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txtCadastrar_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(385, 387);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(89, 13);
            this.linkLabel2.TabIndex = 3;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Esqueci a senha ";
            // 
            // txtWarningForm
            // 
            this.txtWarningForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtWarningForm.AutoSize = true;
            this.txtWarningForm.ForeColor = System.Drawing.Color.Red;
            this.txtWarningForm.Location = new System.Drawing.Point(306, 284);
            this.txtWarningForm.Name = "txtWarningForm";
            this.txtWarningForm.Size = new System.Drawing.Size(139, 13);
            this.txtWarningForm.TabIndex = 5;
            this.txtWarningForm.Text = "Usuario ou senha incorretos";
            this.txtWarningForm.Visible = false;
            // 
            // imgVerSenha
            // 
            this.imgVerSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imgVerSenha.BackColor = System.Drawing.Color.White;
            this.imgVerSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgVerSenha.Image = ((System.Drawing.Image)(resources.GetObject("imgVerSenha.Image")));
            this.imgVerSenha.Location = new System.Drawing.Point(610, 362);
            this.imgVerSenha.Name = "imgVerSenha";
            this.imgVerSenha.Size = new System.Drawing.Size(20, 18);
            this.imgVerSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgVerSenha.TabIndex = 6;
            this.imgVerSenha.TabStop = false;
            this.imgVerSenha.Click += new System.EventHandler(this.imgVerSenha_Click);
            // 
            // imgEsconderSenha
            // 
            this.imgEsconderSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imgEsconderSenha.BackColor = System.Drawing.Color.White;
            this.imgEsconderSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgEsconderSenha.Image = ((System.Drawing.Image)(resources.GetObject("imgEsconderSenha.Image")));
            this.imgEsconderSenha.Location = new System.Drawing.Point(610, 362);
            this.imgEsconderSenha.Name = "imgEsconderSenha";
            this.imgEsconderSenha.Size = new System.Drawing.Size(20, 18);
            this.imgEsconderSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgEsconderSenha.TabIndex = 7;
            this.imgEsconderSenha.TabStop = false;
            this.imgEsconderSenha.Visible = false;
            this.imgEsconderSenha.Click += new System.EventHandler(this.imgEsconderSenha_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(189)))), ((int)(((byte)(142)))));
            this.ClientSize = new System.Drawing.Size(946, 593);
            this.Controls.Add(this.imgEsconderSenha);
            this.Controls.Add(this.imgVerSenha);
            this.Controls.Add(this.txtWarningForm);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.txtCadastrar);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Login";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVerSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEsconderSenha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel txtCadastrar;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label txtWarningForm;
        private System.Windows.Forms.PictureBox imgVerSenha;
        private System.Windows.Forms.PictureBox imgEsconderSenha;
    }
}

