namespace BibliotecaVirtual.Views
{
    partial class LivroView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LivroView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDisponibilidade = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEmprestarItem = new System.Windows.Forms.Button();
            this.listViewUsuarios = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.txtPesquisaUser = new System.Windows.Forms.TextBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblWarningDataEmprestimo = new System.Windows.Forms.Label();
            this.lblWarningDataDevolucao = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDataDevolucao = new System.Windows.Forms.MaskedTextBox();
            this.txtDataEmprestimo = new System.Windows.Forms.MaskedTextBox();
            this.lblListUser = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTipo);
            this.groupBox1.Controls.Add(this.lblDisponibilidade);
            this.groupBox1.Controls.Add(this.lblData);
            this.groupBox1.Controls.Add(this.lblAutor);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTitulo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 384);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(40, 286);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(35, 13);
            this.lblTipo.TabIndex = 12;
            this.lblTipo.Text = "label8";
            // 
            // lblDisponibilidade
            // 
            this.lblDisponibilidade.AutoSize = true;
            this.lblDisponibilidade.Location = new System.Drawing.Point(88, 255);
            this.lblDisponibilidade.Name = "lblDisponibilidade";
            this.lblDisponibilidade.Size = new System.Drawing.Size(35, 13);
            this.lblDisponibilidade.TabIndex = 11;
            this.lblDisponibilidade.Text = "label7";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(42, 225);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(35, 13);
            this.lblData.TabIndex = 11;
            this.lblData.Text = "label6";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(50, 197);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(35, 13);
            this.lblAutor.TabIndex = 10;
            this.lblAutor.Text = "label2";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(7, 10);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 9;
            this.lblId.Text = "Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Disponiblidade :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(144, 169);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(56, 24);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Titulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Autor :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(96, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnEmprestarItem
            // 
            this.btnEmprestarItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEmprestarItem.AutoSize = true;
            this.btnEmprestarItem.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnEmprestarItem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEmprestarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmprestarItem.Location = new System.Drawing.Point(696, 369);
            this.btnEmprestarItem.Name = "btnEmprestarItem";
            this.btnEmprestarItem.Size = new System.Drawing.Size(120, 27);
            this.btnEmprestarItem.TabIndex = 24;
            this.btnEmprestarItem.Text = "Emprestar";
            this.btnEmprestarItem.UseVisualStyleBackColor = false;
            this.btnEmprestarItem.Click += new System.EventHandler(this.btnEmprestarItem_Click);
            // 
            // listViewUsuarios
            // 
            this.listViewUsuarios.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listViewUsuarios.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listViewUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            this.listViewUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewUsuarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Nome,
            this.email});
            this.listViewUsuarios.FullRowSelect = true;
            this.listViewUsuarios.HideSelection = false;
            this.listViewUsuarios.Location = new System.Drawing.Point(490, 145);
            this.listViewUsuarios.MultiSelect = false;
            this.listViewUsuarios.Name = "listViewUsuarios";
            this.listViewUsuarios.Size = new System.Drawing.Size(483, 77);
            this.listViewUsuarios.TabIndex = 25;
            this.listViewUsuarios.UseCompatibleStateImageBehavior = false;
            this.listViewUsuarios.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 40;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nome.Width = 245;
            // 
            // email
            // 
            this.email.Text = "E-mail";
            this.email.Width = 150;
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Procure o usuario que você quer emprestar o item";
            // 
            // txtPesquisaUser
            // 
            this.txtPesquisaUser.Location = new System.Drawing.Point(741, 121);
            this.txtPesquisaUser.Name = "txtPesquisaUser";
            this.txtPesquisaUser.Size = new System.Drawing.Size(116, 20);
            this.txtPesquisaUser.TabIndex = 27;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(863, 119);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(110, 23);
            this.btnPesquisa.TabIndex = 28;
            this.btnPesquisa.Text = "Pesquise";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(487, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Data de Emprestimo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(675, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 29);
            this.label7.TabIndex = 30;
            this.label7.Text = "Emprestar Livro";
            // 
            // lblWarningDataEmprestimo
            // 
            this.lblWarningDataEmprestimo.AutoSize = true;
            this.lblWarningDataEmprestimo.ForeColor = System.Drawing.Color.Red;
            this.lblWarningDataEmprestimo.Location = new System.Drawing.Point(487, 313);
            this.lblWarningDataEmprestimo.Name = "lblWarningDataEmprestimo";
            this.lblWarningDataEmprestimo.Size = new System.Drawing.Size(156, 13);
            this.lblWarningDataEmprestimo.TabIndex = 32;
            this.lblWarningDataEmprestimo.Text = "Data de Emprestimo Obrigatoria";
            this.lblWarningDataEmprestimo.Visible = false;
            // 
            // lblWarningDataDevolucao
            // 
            this.lblWarningDataDevolucao.AutoSize = true;
            this.lblWarningDataDevolucao.ForeColor = System.Drawing.Color.Red;
            this.lblWarningDataDevolucao.Location = new System.Drawing.Point(789, 313);
            this.lblWarningDataDevolucao.Name = "lblWarningDataDevolucao";
            this.lblWarningDataDevolucao.Size = new System.Drawing.Size(154, 13);
            this.lblWarningDataDevolucao.TabIndex = 35;
            this.lblWarningDataDevolucao.Text = "Data de Devolução Obrigatoria";
            this.lblWarningDataDevolucao.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(789, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Data de Devolução";
            // 
            // txtDataDevolucao
            // 
            this.txtDataDevolucao.BackColor = System.Drawing.Color.White;
            this.txtDataDevolucao.Location = new System.Drawing.Point(792, 287);
            this.txtDataDevolucao.Mask = "00/00/0000";
            this.txtDataDevolucao.Name = "txtDataDevolucao";
            this.txtDataDevolucao.Size = new System.Drawing.Size(260, 20);
            this.txtDataDevolucao.TabIndex = 36;
            this.txtDataDevolucao.ValidatingType = typeof(System.DateTime);
            // 
            // txtDataEmprestimo
            // 
            this.txtDataEmprestimo.BackColor = System.Drawing.Color.White;
            this.txtDataEmprestimo.Location = new System.Drawing.Point(490, 287);
            this.txtDataEmprestimo.Mask = "00/00/0000";
            this.txtDataEmprestimo.Name = "txtDataEmprestimo";
            this.txtDataEmprestimo.Size = new System.Drawing.Size(260, 20);
            this.txtDataEmprestimo.TabIndex = 37;
            this.txtDataEmprestimo.ValidatingType = typeof(System.DateTime);
            // 
            // lblListUser
            // 
            this.lblListUser.AutoSize = true;
            this.lblListUser.ForeColor = System.Drawing.Color.Red;
            this.lblListUser.Location = new System.Drawing.Point(490, 225);
            this.lblListUser.Name = "lblListUser";
            this.lblListUser.Size = new System.Drawing.Size(184, 13);
            this.lblListUser.TabIndex = 38;
            this.lblListUser.Text = "É obrigatorio a escolha de um usuario";
            this.lblListUser.Visible = false;
            // 
            // LivroView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(189)))), ((int)(((byte)(142)))));
            this.ClientSize = new System.Drawing.Size(1064, 664);
            this.Controls.Add(this.lblListUser);
            this.Controls.Add(this.txtDataEmprestimo);
            this.Controls.Add(this.txtDataDevolucao);
            this.Controls.Add(this.lblWarningDataDevolucao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblWarningDataEmprestimo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.txtPesquisaUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewUsuarios);
            this.Controls.Add(this.btnEmprestarItem);
            this.Controls.Add(this.groupBox1);
            this.Name = "LivroView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emprestar Item";
            this.Load += new System.EventHandler(this.LivroView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDisponibilidade;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Button btnEmprestarItem;
        private System.Windows.Forms.ListView listViewUsuarios;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPesquisaUser;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblWarningDataEmprestimo;
        private System.Windows.Forms.Label lblWarningDataDevolucao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtDataDevolucao;
        private System.Windows.Forms.MaskedTextBox txtDataEmprestimo;
        private System.Windows.Forms.Label lblListUser;
    }
}