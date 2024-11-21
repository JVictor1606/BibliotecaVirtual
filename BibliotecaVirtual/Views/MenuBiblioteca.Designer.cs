namespace BibliotecaVirtual.Views
{
    partial class MenuBiblioteca
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBibliotecaId = new System.Windows.Forms.Label();
            this.btnEditarBiblioteca = new System.Windows.Forms.Button();
            this.txtBibliotecaNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewBiblioteca = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Titulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Autor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtLimpo = new System.Windows.Forms.Label();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Disponibilidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtBibliotecaId);
            this.groupBox1.Controls.Add(this.btnEditarBiblioteca);
            this.groupBox1.Controls.Add(this.txtBibliotecaNome);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1342, 59);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Biblioteca";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtBibliotecaId
            // 
            this.txtBibliotecaId.AutoSize = true;
            this.txtBibliotecaId.Location = new System.Drawing.Point(1320, 24);
            this.txtBibliotecaId.Name = "txtBibliotecaId";
            this.txtBibliotecaId.Size = new System.Drawing.Size(16, 13);
            this.txtBibliotecaId.TabIndex = 2;
            this.txtBibliotecaId.Text = "Id";
            // 
            // btnEditarBiblioteca
            // 
            this.btnEditarBiblioteca.Location = new System.Drawing.Point(6, 19);
            this.btnEditarBiblioteca.Name = "btnEditarBiblioteca";
            this.btnEditarBiblioteca.Size = new System.Drawing.Size(75, 23);
            this.btnEditarBiblioteca.TabIndex = 1;
            this.btnEditarBiblioteca.Text = "Editar";
            this.btnEditarBiblioteca.UseVisualStyleBackColor = true;
            // 
            // txtBibliotecaNome
            // 
            this.txtBibliotecaNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBibliotecaNome.AutoSize = true;
            this.txtBibliotecaNome.Location = new System.Drawing.Point(87, 24);
            this.txtBibliotecaNome.Name = "txtBibliotecaNome";
            this.txtBibliotecaNome.Size = new System.Drawing.Size(35, 13);
            this.txtBibliotecaNome.TabIndex = 0;
            this.txtBibliotecaNome.Text = "Nome";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(627, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Itens";
            // 
            // listViewBiblioteca
            // 
            this.listViewBiblioteca.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listViewBiblioteca.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listViewBiblioteca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewBiblioteca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            this.listViewBiblioteca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewBiblioteca.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Titulo,
            this.Autor,
            this.Data,
            this.Disponibilidade,
            this.Tipo});
            this.listViewBiblioteca.FullRowSelect = true;
            this.listViewBiblioteca.HideSelection = false;
            this.listViewBiblioteca.Location = new System.Drawing.Point(12, 251);
            this.listViewBiblioteca.MultiSelect = false;
            this.listViewBiblioteca.Name = "listViewBiblioteca";
            this.listViewBiblioteca.Size = new System.Drawing.Size(1342, 528);
            this.listViewBiblioteca.TabIndex = 8;
            this.listViewBiblioteca.UseCompatibleStateImageBehavior = false;
            this.listViewBiblioteca.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 50;
            // 
            // Titulo
            // 
            this.Titulo.Text = "Titulo";
            this.Titulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Titulo.Width = 200;
            // 
            // Autor
            // 
            this.Autor.Text = "Autor";
            this.Autor.Width = 150;
            // 
            // txtLimpo
            // 
            this.txtLimpo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLimpo.AutoSize = true;
            this.txtLimpo.Location = new System.Drawing.Point(602, 235);
            this.txtLimpo.Name = "txtLimpo";
            this.txtLimpo.Size = new System.Drawing.Size(122, 13);
            this.txtLimpo.TabIndex = 9;
            this.txtLimpo.Text = "Nenhum Livro registrado";
            this.txtLimpo.Visible = false;
            // 
            // cmbItem
            // 
            this.cmbItem.AllowDrop = true;
            this.cmbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItem.Items.AddRange(new object[] {
            "Id",
            "Nome",
            "LIvro",
            "Revista",
            "Artigo"});
            this.cmbItem.Location = new System.Drawing.Point(834, 227);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(121, 21);
            this.cmbItem.TabIndex = 16;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(961, 228);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(267, 20);
            this.txtPesquisa.TabIndex = 17;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPesquisar.AutoSize = true;
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(1234, 227);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(76, 24);
            this.btnPesquisar.TabIndex = 18;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(18, 225);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 19;
            this.btnAddItem.Text = "Adicionar";
            this.btnAddItem.UseVisualStyleBackColor = true;
            // 
            // Data
            // 
            this.Data.Text = "Data";
            this.Data.Width = 122;
            // 
            // Disponibilidade
            // 
            this.Disponibilidade.Text = "Disponibilidade";
            this.Disponibilidade.Width = 129;
            // 
            // Tipo
            // 
            this.Tipo.Text = "Tipo";
            // 
            // MenuBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(189)))), ((int)(((byte)(142)))));
            this.ClientSize = new System.Drawing.Size(1366, 794);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.cmbItem);
            this.Controls.Add(this.txtLimpo);
            this.Controls.Add(this.listViewBiblioteca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MenuBiblioteca";
            this.Text = "Bibliotecas";
            this.Load += new System.EventHandler(this.MenuBiblioteca_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txtBibliotecaId;
        private System.Windows.Forms.Button btnEditarBiblioteca;
        private System.Windows.Forms.Label txtBibliotecaNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewBiblioteca;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Titulo;
        private System.Windows.Forms.ColumnHeader Autor;
        private System.Windows.Forms.Label txtLimpo;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader Disponibilidade;
        private System.Windows.Forms.ColumnHeader Tipo;
    }
}