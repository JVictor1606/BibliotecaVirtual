namespace BibliotecaVirtual.Views
{
    partial class MenuView
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
            this.txtUserNome = new System.Windows.Forms.Label();
            this.btnAddBiblioteca = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.Label();
            this.btnEditarPerfil = new System.Windows.Forms.Button();
            this.txtLimpo = new System.Windows.Forms.Label();
            this.listViewBiblioteca = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descrição = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUserNome
            // 
            this.txtUserNome.AutoSize = true;
            this.txtUserNome.Location = new System.Drawing.Point(914, 24);
            this.txtUserNome.Name = "txtUserNome";
            this.txtUserNome.Size = new System.Drawing.Size(35, 13);
            this.txtUserNome.TabIndex = 0;
            this.txtUserNome.Text = "Nome";
            // 
            // btnAddBiblioteca
            // 
            this.btnAddBiblioteca.Location = new System.Drawing.Point(18, 110);
            this.btnAddBiblioteca.Name = "btnAddBiblioteca";
            this.btnAddBiblioteca.Size = new System.Drawing.Size(75, 23);
            this.btnAddBiblioteca.TabIndex = 1;
            this.btnAddBiblioteca.Text = "Adicionar";
            this.btnAddBiblioteca.UseVisualStyleBackColor = true;
            this.btnAddBiblioteca.Click += new System.EventHandler(this.btnAddBiblioteca_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.btnEditarPerfil);
            this.groupBox1.Controls.Add(this.txtUserNome);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(957, 59);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Perfil";
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(87, 24);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(32, 13);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Text = "Email";
            // 
            // btnEditarPerfil
            // 
            this.btnEditarPerfil.Location = new System.Drawing.Point(6, 19);
            this.btnEditarPerfil.Name = "btnEditarPerfil";
            this.btnEditarPerfil.Size = new System.Drawing.Size(75, 23);
            this.btnEditarPerfil.TabIndex = 1;
            this.btnEditarPerfil.Text = "Editar";
            this.btnEditarPerfil.UseVisualStyleBackColor = true;
            this.btnEditarPerfil.Click += new System.EventHandler(this.btnEditarPerfil_Click);
            // 
            // txtLimpo
            // 
            this.txtLimpo.AutoSize = true;
            this.txtLimpo.Location = new System.Drawing.Point(408, 120);
            this.txtLimpo.Name = "txtLimpo";
            this.txtLimpo.Size = new System.Drawing.Size(150, 13);
            this.txtLimpo.TabIndex = 5;
            this.txtLimpo.Text = "Nenhuma biblioteca registrada";
            this.txtLimpo.Visible = false;
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
            this.Nome,
            this.Descrição});
            this.listViewBiblioteca.FullRowSelect = true;
            this.listViewBiblioteca.HideSelection = false;
            this.listViewBiblioteca.Location = new System.Drawing.Point(18, 139);
            this.listViewBiblioteca.MultiSelect = false;
            this.listViewBiblioteca.Name = "listViewBiblioteca";
            this.listViewBiblioteca.Size = new System.Drawing.Size(943, 402);
            this.listViewBiblioteca.TabIndex = 4;
            this.listViewBiblioteca.UseCompatibleStateImageBehavior = false;
            this.listViewBiblioteca.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nome.Width = 200;
            // 
            // Descrição
            // 
            this.Descrição.Text = "Descrição";
            this.Descrição.Width = 250;
            // 
            // MenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(189)))), ((int)(((byte)(142)))));
            this.ClientSize = new System.Drawing.Size(973, 591);
            this.Controls.Add(this.txtLimpo);
            this.Controls.Add(this.listViewBiblioteca);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddBiblioteca);
            this.Name = "MenuView";
            this.Text = "MenuView";
            this.Load += new System.EventHandler(this.MenuView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtUserNome;
        private System.Windows.Forms.Button btnAddBiblioteca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEditarPerfil;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.Label txtLimpo;
        private System.Windows.Forms.ListView listViewBiblioteca;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Descrição;
    }
}