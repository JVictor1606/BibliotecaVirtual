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
    public partial class MenuBiblioteca : Form
    {
        private readonly Item _item;
        private readonly ItemRepository _repository;
        private Biblioteca _biblioteca;
        private User _user;
        public MenuBiblioteca(User user, Biblioteca biblioteca)
        {
            InitializeComponent();
            _biblioteca = biblioteca;
            _user = user;
            _repository = new ItemRepository(new AppDbContext());
            
        }
        public MenuBiblioteca(Biblioteca biblioteca)
        {
            InitializeComponent();
            _biblioteca = biblioteca;
            _repository = new ItemRepository(new AppDbContext());

        }
        public MenuBiblioteca()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void MenuBiblioteca_Load(object sender, EventArgs e)
        {
            txtBibliotecaId.Text = Convert.ToString(_biblioteca.Id);
            txtBibliotecaNome.Text = _biblioteca.Nome;

            PreencherGrid();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastroItem tela = new CadastroItem(_biblioteca, _item);
            tela.ShowDialog();
        }


        private void PreencherGrid()
        {
            var itens = _repository.GetAllItens().Where(i => i.BibliotecaId == _biblioteca.Id).ToList();

            if (!itens.Any())
            {
                MessageBox.Show("Nenhuma biblioteca encontrada para este usuário.");
            }

            foreach (var item in itens)
            {
                ListViewItem it = new ListViewItem();
                it.Tag = item;
                it.Text = item.Id.ToString();
                it.SubItems.Add(item.Titulo);
                it.SubItems.Add(item.Autor);
                it.SubItems.Add(item.Data.ToString("dd/MM/yyyy"));
                it.SubItems.Add(item.Disponivel.ToString());
                it.SubItems.Add(item.Tipo);
                

                listViewBiblioteca.Items.Add(it);
            }

            txtLimpo.Visible = listViewBiblioteca.Items.Count == 0;
        }

        private void PreencherGrid(List<Item> itens)
        {
            listViewBiblioteca.Items.Clear();

            if (!itens.Any())
            {
                txtLimpo.Visible = true;
            }

            txtLimpo.Visible = false;
            foreach (var it in itens)
            {
                var item = new ListViewItem();
                item.Tag = it;
                item.Text = it.Id.ToString();
                item.SubItems.Add(it.Titulo);
                item.SubItems.Add(it.Autor);
                item.SubItems.Add(it.Data.ToString("dd/MM/yyyy"));
                item.SubItems.Add(it.Disponivel.ToString());
                item.SubItems.Add(it.Tipo);
                listViewBiblioteca.Items.Add(item);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int tipo = cmbItem.SelectedIndex;

            if (tipo < 0)
            {
                MessageBox.Show("Por favor, selecione um tipo para pesquisar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            switch (tipo)
            {
                case 0:
                    if (string.IsNullOrEmpty(txtPesquisa.Text))
                    {
                        MessageBox.Show("Você não pesquisou nenhum Item", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    int tipoPesquisa = cmbItem.SelectedIndex;
                    List<Item> lista = _repository.Pesquisar(tipoPesquisa, txtPesquisa.Text.Trim());
                    PreencherGrid(lista);
                    break;
                    case 1:
                    if (string.IsNullOrEmpty(txtPesquisa.Text))
                    {
                        MessageBox.Show("Você não pesquisou nenhum Item", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    int tipoPesquisa2 = cmbItem.SelectedIndex;
                    List<Item> lista2 = _repository.Pesquisar(tipoPesquisa2, txtPesquisa.Text.Trim());
                    PreencherGrid(lista2);
                    break;
                case 2:
                    List<Item> listaLivro = _repository.GetItemByLivro();
                    PreencherGrid(listaLivro);

                    if(listaLivro.Count == 0)
                    {
                        MessageBox.Show("Nenhum livro para mostrar.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PreencherGrid();
                    }
                    break;

                case 3:
                    List<Item> listaRevista = _repository.GetItemByRevista();
                    PreencherGrid(listaRevista);
                    if (listaRevista.Count == 0)
                    {
                        MessageBox.Show("Nenhuma Revista para mostrar.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PreencherGrid();
                    }
                    break;
                case 4:
                    List<Item> listaArtigo = _repository.GetItemByArtigo();
                    PreencherGrid(listaArtigo);
                    if (listaArtigo.Count == 0)
                    {
                        MessageBox.Show("Nenhum Artigo para mostrar.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PreencherGrid();
                    }
                    break;
            }
                

        }

        private void MenuBiblioteca_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void FiltrarItens(string pesquisa)
        {
            
            var itens = _repository.GetAllItens()
                                    .Where(i => i.BibliotecaId == _biblioteca.Id &&
                                                i.Titulo.Contains(pesquisa)).ToList();


            PreencherGrid(itens);
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            FiltrarItens(txtPesquisa.Text);
        }
    }
}
