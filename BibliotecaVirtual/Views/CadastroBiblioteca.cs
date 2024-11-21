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
    public partial class CadastroBiblioteca : Form
    {
        private readonly BibliotecaRepository _repository;
        private User _user;
        private Biblioteca _biblioteca;
        public CadastroBiblioteca(User user)
        {
            InitializeComponent();
            _repository = new BibliotecaRepository(new AppDbContext());
            _user = user;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CadastroBiblioteca_Load(object sender, EventArgs e)
        {
            if(_biblioteca == null)
            {
                _biblioteca = new Biblioteca();
            }
            else
            {
                PreencherBiblioteca(_biblioteca);
            }
        }

        private void PreencherBiblioteca(Biblioteca bibliote)
        {
            txtTitulo.Text = "Atualize a sua biblioteca";

            txtNome.Text = bibliote.Nome;
            txtTelefone.Text = bibliote.Telefone;
            txtDescricao.Text = bibliote.Descricao;

            btnCriarBiblio.Text = "Atualizar";

        }
        private bool ValidForm()
        {
            var isValid = true;

            lblWarningNome.Text = "";
            lblWarningTelefone.Text = "";
            lblWarningDescricao.Text = "";

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                lblWarningNome.Visible = true;
                lblWarningNome.Text = "Informe o nome do Usuario";
                isValid = false;

            }
            if (string.IsNullOrEmpty(txtTelefone.Text))
            {
                lblWarningTelefone.Visible = true;
                lblWarningTelefone.Text = "Informe o telefone da Biblioteca";
                isValid = false;
            }
            if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                lblWarningDescricao.Visible = true;
                lblWarningDescricao.Text = ("Informe a descrição da Biblioteca");
                isValid = false;
            }

            return isValid;
        }

        private void btnCriarBiblio_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidForm())
                {
                    Biblioteca bi = new Biblioteca();
                   bi.Nome = txtNome.Text;
                    bi.Telefone = txtTelefone.Text;
                    bi.Descricao = txtDescricao.Text;
                    bi.UserId = _user.Id;


                    DialogResult yes = MessageBox.Show("Você tem certeza que deseja salvar essa biblioteca?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (DialogResult.Yes == yes)
                    {
                        if (_biblioteca.Id < 1)
                        {
                            _repository.Create(bi);
                        }
                        else
                        {
                            bi.Id = _biblioteca.Id;
                            _repository.Update(bi);
                        }
                        MessageBox.Show($"Obrigado, {bi.Nome} foi registrado(a) com sucesso", "Registro Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                        MenuView tela = new MenuView(_user);
                        tela.Show();
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
