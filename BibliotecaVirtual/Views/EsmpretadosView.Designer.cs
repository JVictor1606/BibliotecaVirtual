namespace BibliotecaVirtual.Views
{
    partial class EsmpretadosView
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
            this.listViewEmprestados = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Titulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Autor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Disponibilidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtLimpo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewEmprestados
            // 
            this.listViewEmprestados.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listViewEmprestados.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listViewEmprestados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewEmprestados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            this.listViewEmprestados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewEmprestados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Titulo,
            this.Autor,
            this.Data,
            this.Disponibilidade,
            this.Tipo});
            this.listViewEmprestados.FullRowSelect = true;
            this.listViewEmprestados.HideSelection = false;
            this.listViewEmprestados.Location = new System.Drawing.Point(12, 128);
            this.listViewEmprestados.MultiSelect = false;
            this.listViewEmprestados.Name = "listViewEmprestados";
            this.listViewEmprestados.Size = new System.Drawing.Size(1095, 514);
            this.listViewEmprestados.TabIndex = 9;
            this.listViewEmprestados.UseCompatibleStateImageBehavior = false;
            this.listViewEmprestados.View = System.Windows.Forms.View.Details;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Itens Pego por Emprestimos";
            // 
            // txtLimpo
            // 
            this.txtLimpo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLimpo.AutoSize = true;
            this.txtLimpo.Location = new System.Drawing.Point(470, 112);
            this.txtLimpo.Name = "txtLimpo";
            this.txtLimpo.Size = new System.Drawing.Size(126, 13);
            this.txtLimpo.TabIndex = 11;
            this.txtLimpo.Text = "Nenhum item encontrado";
            this.txtLimpo.Visible = false;
            // 
            // EsmpretadosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(189)))), ((int)(((byte)(142)))));
            this.ClientSize = new System.Drawing.Size(1119, 701);
            this.Controls.Add(this.txtLimpo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewEmprestados);
            this.Name = "EsmpretadosView";
            this.Text = "Esmpretados";
            this.Load += new System.EventHandler(this.EsmpretadosView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewEmprestados;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Titulo;
        private System.Windows.Forms.ColumnHeader Autor;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader Disponibilidade;
        private System.Windows.Forms.ColumnHeader Tipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtLimpo;
    }
}