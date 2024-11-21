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
    public partial class CadastroUser : Form
    {
        private User _user;
        private UserRepository _repository;

        
        public CadastroUser()
        {
            InitializeComponent();
            _repository = new UserRepository(new AppDbContext());
            this.FormClosed += CadastroUser_FormClosed;
        }

        public CadastroUser(User user)
        {
            InitializeComponent();
            _repository = new UserRepository(new AppDbContext());
            _user = user;
            this.FormClosed += CadastroUser_FormClosed;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CadastroUser_Load(object sender, EventArgs e)
        {
            if (_user == null)
            {
                _user = new User();
            }
            else
            {
                PreencherUser(_user);
            }

        }

        private void PreencherUser(User user)
        {
            var getUser = _repository.GetById(user.Id);

            if(getUser.Id == _user.Id)
            {
                txtTitulo.Text = "Atualize o seu perfil";

                txtConfirSenha.Visible = false;

                txtNome.Text = user.Name;
                txtEmail.Text = user.Email;

                btnCadastrar.Text = "Atualizar";
            }

           
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(ValidForm())
                {
                    User user = new User();
                    user.Name = txtNome.Text;
                    user.Email = txtEmail.Text;
                    user.Password = txtSenha.Text;
                    user.ConfirmPassword = txtConfirSenha.Text;


                    DialogResult yes = MessageBox.Show("Você tem certeza que deseja salvar esse usuario?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (DialogResult.Yes == yes)
                    {
                        if (_user.Id < 1)
                        {
                            _repository.Create(user);
                        }
                        else
                        {
                            user.Id = _user.Id;
                            _repository.Update(user);
                        }
                        MessageBox.Show($"Obrigado, {user.Name} foi registrado(a) com sucesso", "Registro Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                        Form1 tela = new Form1();
                        tela.ShowDialog();
                    }
                }

               
            }
            catch (Exception)
            {

                throw;
            }
        }

        private bool ValidForm()
        {
            var isValid = true;

            txtWarningNome.Text = "";
            txtWarningEmail.Text = "";
            txtWarningSenha.Text = "";
            txtWarningConfirm.Text = "";

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                txtWarningNome.Visible = true;
                txtWarningNome.Text = "Informe o nome do Usuario";
                isValid = false;

            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                txtWarningEmail.Visible = true;
                txtWarningEmail.Text = "Informe o email do Usuario";
                isValid = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                txtWarningEmail.Visible = true;
                txtWarningEmail.Text = ("Informe um e-mail válido");
                isValid = false;
            }
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                txtWarningSenha.Visible = true;
                txtWarningSenha.Text = ("Informe a senha do Usuario");
                isValid = false;
            }
            if (string.IsNullOrEmpty(txtConfirSenha.Text))
            {
                txtWarningConfirm.Visible = true;
                txtWarningConfirm.Text = ("Confirme a senha do Usuario");
                isValid = false;
            }
            if (txtConfirSenha.Text != txtSenha.Text)
            {
                txtWarningConfirm.Visible = true;
                txtWarningConfirm.Text = ("As senhas não coincidem");
                isValid = false;
            }

            return isValid;
        }

        private void CadastroUser_FormClosed(object sender, FormClosedEventArgs e)
        {

            Form1 tela = new Form1();
            tela.Show();
        }
    }
}
