namespace BibliotecaVirtual.Views
{
    partial class CadastroItem
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblDisponibilidade = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.cmbDisponibilidade = new System.Windows.Forms.ComboBox();
            this.lblEditora = new System.Windows.Forms.Label();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.txtPeriodicidade = new System.Windows.Forms.TextBox();
            this.lblPeriodicidade = new System.Windows.Forms.Label();
            this.btnCriarItem = new System.Windows.Forms.Button();
            this.lblEdicao = new System.Windows.Forms.Label();
            this.txtEdicao = new System.Windows.Forms.TextBox();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.txtDOI = new System.Windows.Forms.TextBox();
            this.lblDOI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(15, 186);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(71, 13);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Titulo do Item";
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(12, 30);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(236, 33);
            this.txtTitulo.TabIndex = 8;
            this.txtTitulo.Text = "Crie o seu item";
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(15, 205);
            this.txtNome.Margin = new System.Windows.Forms.Padding(6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(260, 26);
            this.txtNome.TabIndex = 9;
            // 
            // txtAutor
            // 
            this.txtAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.Location = new System.Drawing.Point(325, 205);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(6);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(260, 26);
            this.txtAutor.TabIndex = 10;
            // 
            // cmbItem
            // 
            this.cmbItem.AllowDrop = true;
            this.cmbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItem.Location = new System.Drawing.Point(15, 143);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(121, 21);
            this.cmbItem.TabIndex = 17;
            this.cmbItem.SelectedIndexChanged += new System.EventHandler(this.cmbItem_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tipo do Item";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(322, 186);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(70, 13);
            this.lblAutor.TabIndex = 19;
            this.lblAutor.Text = "Autor do Item";
            // 
            // txtISBN
            // 
            this.txtISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(325, 325);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(6);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(260, 26);
            this.txtISBN.TabIndex = 22;
            this.txtISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtISBN_KeyPress);
            // 
            // txtGenero
            // 
            this.txtGenero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenero.Location = new System.Drawing.Point(647, 325);
            this.txtGenero.Margin = new System.Windows.Forms.Padding(6);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(260, 26);
            this.txtGenero.TabIndex = 23;
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.Color.White;
            this.txtData.Location = new System.Drawing.Point(647, 209);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(260, 20);
            this.txtData.TabIndex = 24;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(644, 186);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(68, 13);
            this.lblData.TabIndex = 25;
            this.lblData.Text = "Data do Item";
            // 
            // lblDisponibilidade
            // 
            this.lblDisponibilidade.AutoSize = true;
            this.lblDisponibilidade.Location = new System.Drawing.Point(15, 306);
            this.lblDisponibilidade.Name = "lblDisponibilidade";
            this.lblDisponibilidade.Size = new System.Drawing.Size(116, 13);
            this.lblDisponibilidade.TabIndex = 26;
            this.lblDisponibilidade.Text = "Disponibilidade do Item";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(322, 306);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(73, 13);
            this.lblISBN.TabIndex = 27;
            this.lblISBN.Text = "ISBN do Livro";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(644, 306);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(83, 13);
            this.lblGenero.TabIndex = 28;
            this.lblGenero.Text = "Gênero do Livro";
            // 
            // cmbDisponibilidade
            // 
            this.cmbDisponibilidade.AllowDrop = true;
            this.cmbDisponibilidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisponibilidade.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cmbDisponibilidade.Location = new System.Drawing.Point(18, 325);
            this.cmbDisponibilidade.Name = "cmbDisponibilidade";
            this.cmbDisponibilidade.Size = new System.Drawing.Size(121, 21);
            this.cmbDisponibilidade.TabIndex = 29;
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.Location = new System.Drawing.Point(16, 399);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(94, 13);
            this.lblEditora.TabIndex = 30;
            this.lblEditora.Text = "Editora da Revista";
            // 
            // txtEditora
            // 
            this.txtEditora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditora.Location = new System.Drawing.Point(15, 418);
            this.txtEditora.Margin = new System.Windows.Forms.Padding(6);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(260, 26);
            this.txtEditora.TabIndex = 31;
            // 
            // txtPeriodicidade
            // 
            this.txtPeriodicidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPeriodicidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriodicidade.Location = new System.Drawing.Point(325, 418);
            this.txtPeriodicidade.Margin = new System.Windows.Forms.Padding(6);
            this.txtPeriodicidade.Name = "txtPeriodicidade";
            this.txtPeriodicidade.Size = new System.Drawing.Size(260, 26);
            this.txtPeriodicidade.TabIndex = 32;
            // 
            // lblPeriodicidade
            // 
            this.lblPeriodicidade.AutoSize = true;
            this.lblPeriodicidade.Location = new System.Drawing.Point(322, 399);
            this.lblPeriodicidade.Name = "lblPeriodicidade";
            this.lblPeriodicidade.Size = new System.Drawing.Size(125, 13);
            this.lblPeriodicidade.TabIndex = 34;
            this.lblPeriodicidade.Text = "Periodicidade da Revista";
            // 
            // btnCriarItem
            // 
            this.btnCriarItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCriarItem.AutoSize = true;
            this.btnCriarItem.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnCriarItem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCriarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarItem.Location = new System.Drawing.Point(559, 644);
            this.btnCriarItem.Name = "btnCriarItem";
            this.btnCriarItem.Size = new System.Drawing.Size(114, 37);
            this.btnCriarItem.TabIndex = 35;
            this.btnCriarItem.Text = "Criar";
            this.btnCriarItem.UseVisualStyleBackColor = false;
            this.btnCriarItem.Click += new System.EventHandler(this.btnCriarBiblio_Click);
            // 
            // lblEdicao
            // 
            this.lblEdicao.AutoSize = true;
            this.lblEdicao.Location = new System.Drawing.Point(644, 399);
            this.lblEdicao.Name = "lblEdicao";
            this.lblEdicao.Size = new System.Drawing.Size(94, 13);
            this.lblEdicao.TabIndex = 36;
            this.lblEdicao.Text = "Edição da Revista";
            // 
            // txtEdicao
            // 
            this.txtEdicao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEdicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdicao.Location = new System.Drawing.Point(647, 418);
            this.txtEdicao.Margin = new System.Windows.Forms.Padding(6);
            this.txtEdicao.Name = "txtEdicao";
            this.txtEdicao.Size = new System.Drawing.Size(260, 26);
            this.txtEdicao.TabIndex = 37;
            // 
            // txtVolume
            // 
            this.txtVolume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVolume.Location = new System.Drawing.Point(15, 513);
            this.txtVolume.Margin = new System.Windows.Forms.Padding(6);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(260, 26);
            this.txtVolume.TabIndex = 38;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(16, 494);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(96, 13);
            this.lblVolume.TabIndex = 39;
            this.lblVolume.Text = "Volume da Revista";
            // 
            // txtDOI
            // 
            this.txtDOI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDOI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDOI.Location = new System.Drawing.Point(325, 513);
            this.txtDOI.Margin = new System.Windows.Forms.Padding(6);
            this.txtDOI.Name = "txtDOI";
            this.txtDOI.Size = new System.Drawing.Size(260, 26);
            this.txtDOI.TabIndex = 40;
            // 
            // lblDOI
            // 
            this.lblDOI.AutoSize = true;
            this.lblDOI.Location = new System.Drawing.Point(322, 494);
            this.lblDOI.Name = "lblDOI";
            this.lblDOI.Size = new System.Drawing.Size(117, 13);
            this.lblDOI.TabIndex = 41;
            this.lblDOI.Text = "DOI do Artigo Cientifico";
            // 
            // CadastroItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(189)))), ((int)(((byte)(142)))));
            this.ClientSize = new System.Drawing.Size(1290, 734);
            this.Controls.Add(this.lblDOI);
            this.Controls.Add(this.txtDOI);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.txtEdicao);
            this.Controls.Add(this.lblEdicao);
            this.Controls.Add(this.btnCriarItem);
            this.Controls.Add(this.lblPeriodicidade);
            this.Controls.Add(this.txtPeriodicidade);
            this.Controls.Add(this.txtEditora);
            this.Controls.Add(this.lblEditora);
            this.Controls.Add(this.cmbDisponibilidade);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblDisponibilidade);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbItem);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "CadastroItem";
            this.Text = "Cadastrar Item";
            this.Load += new System.EventHandler(this.CadastroItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblDisponibilidade;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.ComboBox cmbDisponibilidade;
        private System.Windows.Forms.Label lblEditora;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.TextBox txtPeriodicidade;
        private System.Windows.Forms.Label lblPeriodicidade;
        private System.Windows.Forms.Button btnCriarItem;
        private System.Windows.Forms.Label lblEdicao;
        private System.Windows.Forms.TextBox txtEdicao;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TextBox txtDOI;
        private System.Windows.Forms.Label lblDOI;
    }
}