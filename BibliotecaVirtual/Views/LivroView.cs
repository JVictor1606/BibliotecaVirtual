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
        private readonly Emprestimo _emprestimo;
        private readonly User _user;
        private readonly EmprestimoRepository _repository;
        private readonly ItemRepository _repositoryItem;
        private readonly Biblioteca _biblioteca;
        public LivroView(Item item)
        {
            InitializeComponent();
            _item = item;
            _repository = new EmprestimoRepository(new AppDbContext());
            _repositoryItem = new ItemRepository(new AppDbContext());
        }

        private void LivroView_Load(object sender, EventArgs e)
        {
            PreencherCampos(_item);
            txtDataEmprestimo.Text = DateTime.Now.ToString("dd/MM/yyyy"); 
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

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisaUser.Text.Trim();

            if (string.IsNullOrWhiteSpace(pesquisa))
            {
                MessageBox.Show("Digite algo para pesquisar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var users = _repository.PesquiseUser(pesquisa);
            PreencherListaUsuarios(users);
        }

        private void PreencherListaUsuarios(List<User> users)
        {
            listViewUsuarios.Items.Clear();

            foreach (var user in users)
            {
                var item = new ListViewItem();
                item.Tag = user;
                item.Text = user.Id.ToString();
                item.SubItems.Add(user.Name);
                item.SubItems.Add(user.Email);

                listViewUsuarios.Items.Add(item);
            }
        }

        private void btnEmprestarItem_Click(object sender, EventArgs e)
        {
            if (listViewUsuarios.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um usuário para o empréstimo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedUser = (User)listViewUsuarios.SelectedItems[0].Tag;

            // Validações adicionais
            if (!_item.Disponivel)
            {
                MessageBox.Show("Este item já foi emprestado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            var emprestimo = new Emprestimo
            {
                ItemId = _item.Id,
                UserId = selectedUser.Id,
                DataEmprestimo = DateTime.Parse(txtDataEmprestimo.Text),
                DataDevolucao = DateTime.Parse(txtDataDevolucao.Text),
                Concluido = false
            };


            _repository.Create(emprestimo);

            _item.Disponivel = false;
            _repositoryItem.Update(_item);

            MessageBox.Show($"Empréstimo realizado com sucesso! \n Para {selectedUser.Name}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
