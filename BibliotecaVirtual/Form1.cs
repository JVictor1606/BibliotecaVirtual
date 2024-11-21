using BibliotecaVirtual.Data;
using BibliotecaVirtual.Data.Repository;
using BibliotecaVirtual.Models;
using BibliotecaVirtual.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaVirtual
{
    public partial class Form1 : Form
    {
        private User _user;
        private UserRepository _repository;

        public Form1()
        {
            InitializeComponent();
            _repository = new UserRepository(new AppDbContext());
            this.imgVerSenha.Click += new System.EventHandler(this.imgVerSenha_Click);
            this.imgEsconderSenha.Click += new System.EventHandler(this.imgEsconderSenha_Click);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
        }

        private void txtCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CadastroUser tela = new CadastroUser();
            tela.ShowDialog();
        }

        private bool ValidForm()
        {
            txtWarningForm.Visible = false;
            var isValid = true;
            var user = _repository.GetByIdEmail(txtEmail.Text);

            if (user == null)
            {
                txtWarningForm.Visible = true;
            }

            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSenha.Text))
            {
                txtWarningForm.Visible = true;
                txtWarningForm.Text = "Informe o email ou a senha do Usuario";
                isValid = false;

                
            }

            return isValid;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidForm())
            {

                var user = _repository.AuthenticaUser(new NetworkCredential(txtEmail.Text, txtSenha.Text));

                if (user != null)
                {
                    
                    this.Hide();
                    MenuView tela = new MenuView(user);
                    tela.Show();


                }
            }
            else
            {
                txtWarningForm.Visible = true;
            }
        }

        private void imgVerSenha_Click(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = false;
            imgVerSenha.Visible = false;
            imgEsconderSenha.Visible = true;
        }

        private void imgEsconderSenha_Click(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
            imgEsconderSenha.Visible = false;
            imgVerSenha.Visible = true;
        }
    }
}
