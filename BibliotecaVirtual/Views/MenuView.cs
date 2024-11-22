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
    public partial class MenuView : Form
    {
        private User _user;
        private readonly BibliotecaRepository _repository;
        public MenuView(User user)
        {
            InitializeComponent();
            _user = user;
            _repository = new BibliotecaRepository(new AppDbContext());
        }

        private void MenuView_Load(object sender, EventArgs e)
        {
            txtUserNome.Text = _user.Name;
            txtEmail.Text = _user.Email;

            PreencherGrid();
        }

        private void PreencherGrid()
        {



            listViewBiblioteca.Items.Clear();

            var bibliotecas = _repository.GetAllBibliotecas().Where(b => b.UserId == _user.Id).ToList();

            if (!bibliotecas.Any())
            {
                MessageBox.Show("Nenhuma biblioteca encontrada para este usuário.");
            }

            foreach (var item in bibliotecas)
            {
                ListViewItem it = new ListViewItem();
                it.Tag = item;
                it.Text = item.Id.ToString();
                it.SubItems.Add(item.Nome);
                it.SubItems.Add(item.Descricao);

                listViewBiblioteca.Items.Add(it);
            }

            txtLimpo.Visible = listViewBiblioteca.Items.Count == 0;
        }

        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastroUser tela = new CadastroUser(_user);
            tela.ShowDialog();
            this.Show();
        }

        private void btnAddBiblioteca_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastroBiblioteca tela = new CadastroBiblioteca(_user);
            tela.ShowDialog();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPesquisa.Text))
            {
                MessageBox.Show("Você não pesquisou nenhuma Biblioteca", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int tipoPesquisa = cmbBiblioteca.SelectedIndex;
            List<Biblioteca> lista = _repository.Pesquisar(tipoPesquisa,txtPesquisa.Text.Trim());
            PreencherGrid(lista);

        }

        private void PreencherGrid(List<Biblioteca> bibliotecas)
        {
            listViewBiblioteca.Items.Clear();

            if (!bibliotecas.Any())
            {
                txtLimpo.Visible = true;
            }

            txtLimpo.Visible = false;
            foreach (var biblioteca in bibliotecas)
            {
                var item = new ListViewItem();
                item.Tag = biblioteca;
                item.Text = biblioteca.Id.ToString();
                item.SubItems.Add(biblioteca.Nome);
                item.SubItems.Add(biblioteca.Descricao);
                listViewBiblioteca.Items.Add(item);
            }
        }

        private void listViewBiblioteca_DoubleClick(object sender, EventArgs e)
        {
            if (listViewBiblioteca.SelectedItems.Count > 0)
            {
                var selectedItem = listViewBiblioteca.SelectedItems[0];
                var biblioteca = selectedItem.Tag as Biblioteca;

                if (biblioteca != null)
                {
                    // Abrir a nova página MenuBiblioteca
                    MenuBiblioteca menuBiblioteca = new MenuBiblioteca(_user, biblioteca);
                    this.Hide();
                    menuBiblioteca.ShowDialog();
                    this.Show();

                    // Atualizar a lista após fechar a página
                    PreencherGrid();
                }
            }
        }

        private void MenuView_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja fechar o aplicativo?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void FiltrarItens(string pesquisa)
        {

            var bi = _repository.GetAllBibliotecas()
                                    .Where(i => i.UserId == _user.Id &&
                                                i.Nome.Contains(pesquisa)).ToList();


            PreencherGrid(bi);
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            FiltrarItens(txtPesquisa.Text);
        }
    }
}
