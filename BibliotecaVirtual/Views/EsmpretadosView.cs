using BibliotecaVirtual.Data;
using BibliotecaVirtual.Data.Repository;
using BibliotecaVirtual.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaVirtual.Views
{
    public partial class EsmpretadosView : Form
    {
        private readonly User _user;
        private readonly EmprestimoRepository _repository;
        private readonly Item _item;
        public EsmpretadosView(User user)
        {
            InitializeComponent();
            _user = user;
            _repository = new EmprestimoRepository(new AppDbContext());

        }

        private void EsmpretadosView_Load(object sender, EventArgs e)
        {
            PreencherGrid();
        }

        private void PreencherGrid()
        {
            var itens = _repository.GetAllEmprestimos().Where(i => i.UserId == _user.Id).ToList();

            foreach (var emprestimo in itens)
            {

                var item = new ListViewItem
                {
                    Tag = emprestimo,
                    Text = emprestimo.Id.ToString()
                };

                item.SubItems.Add(emprestimo.Item.Titulo);
                item.SubItems.Add(emprestimo.Item.Autor); 
                item.SubItems.Add(emprestimo.DataEmprestimo?.ToString("dd/MM/yyyy")); 
                item.SubItems.Add(emprestimo.DataDevolucao?.ToString("dd/MM/yyyy"));  
                item.SubItems.Add(emprestimo.Concluido ? "Sim" : "Não"); 


                listViewEmprestados.Items.Add(item);
            }

            txtLimpo.Visible = listViewEmprestados.Items.Count == 0;
        }
    }
}
