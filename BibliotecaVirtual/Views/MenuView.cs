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
        }

        private void btnAddBiblioteca_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastroBiblioteca tela = new CadastroBiblioteca(_user);
            tela.ShowDialog();
        }
    }
}
