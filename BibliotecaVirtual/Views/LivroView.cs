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
    public partial class LivroView : Form
    {
        private readonly Item _item;
        private readonly ItemRepository _repository;
        private readonly Biblioteca _biblioteca;
        public LivroView(Item item)
        {
            InitializeComponent();
            _item = item;
            _repository = new ItemRepository(new AppDbContext());
        }

        private void LivroView_Load(object sender, EventArgs e)
        {
            PreencherCampos(_item);
        }

        private void PreencherCampos(Item item)
        {
            lblId.Text = Convert.ToString(item.Id);
            lblTitulo.Text = item.Titulo;
            lblAutor.Text = item.Autor;
            lblData.Text =Convert.ToString(item.Data);
            lblDisponibilidade.Text = VerDisponilibilidade(item.Disponivel);
            lblTipo.Text = item.Tipo;
        }

        private string VerDisponilibilidade(bool disponivel)
        {
            if(disponivel == true)
            {
                return lblDisponibilidade.Text = "Sim";
            }
            else
            {
                 return lblDisponibilidade.Text = "Não";
            }

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
