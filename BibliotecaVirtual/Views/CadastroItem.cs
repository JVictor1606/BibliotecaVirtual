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
    public partial class CadastroItem : Form
    {
        private readonly Biblioteca _biblioteca;
        private readonly ItemRepository _repository;
        private Item _item;
        public CadastroItem(Biblioteca biblioteca)
        {
            InitializeComponent();
            _biblioteca = biblioteca;
            _repository = new ItemRepository(new AppDbContext());
            cmbItem.DataSource = Enum.GetValues(typeof(ItemType));
        }

        public CadastroItem(Biblioteca biblioteca, Item item = null)
        {
            InitializeComponent();
            _biblioteca = biblioteca;
            _repository = new ItemRepository(new AppDbContext());
            cmbItem.DataSource = Enum.GetValues(typeof(ItemType));

            if (item != null)
            {
                _item = item;
            }
            else
            {
                _item= null;
            }
        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtISBN.Enabled = false;
            txtGenero.Enabled = false;
            txtEditora.Enabled = false;
            txtPeriodicidade.Enabled = false;
            txtEdicao.Enabled = false;
            txtVolume.Enabled = false;
            txtDOI.Enabled = false;

            int tipo = cmbItem.SelectedIndex;

            switch (tipo)
            {
                case 2:
                    txtEditora.Enabled = true;
                    txtPeriodicidade.Enabled = true;
                    txtEdicao.Enabled = true;
                    txtVolume.Enabled = true;
                break;
                case 1:
                    txtISBN.Enabled = true;
                    txtGenero.Enabled = true;
                break ;
                case 3:
                    txtDOI.Enabled = true;
                break ;

            }

            TextBox_Color();
        }

        private void CadastroItem_Load(object sender, EventArgs e)
        {
            txtData.Text = DateTime.Now.ToString();
        }

        private void TextBox_Color()
        {
            Color disabledColor = Color.Gray;

            txtISBN.BackColor = txtISBN.Enabled ? SystemColors.Window : disabledColor;
            txtGenero.BackColor = txtGenero.Enabled ? SystemColors.Window : disabledColor;
            txtEditora.BackColor = txtEditora.Enabled ? SystemColors.Window : disabledColor;
            txtPeriodicidade.BackColor = txtPeriodicidade.Enabled ? SystemColors.Window : disabledColor;
            txtEdicao.BackColor = txtEdicao.Enabled ? SystemColors.Window : disabledColor;
            txtVolume.BackColor = txtVolume.Enabled ? SystemColors.Window : disabledColor;
            txtDOI.BackColor = txtDOI.Enabled ? SystemColors.Window : disabledColor;
        }

        private void btnCriarBiblio_Click(object sender, EventArgs e)
        {
            try
            {
                Item newItem = null;

                int tipo = cmbItem.SelectedIndex;
                string tipos = cmbItem.SelectedItem?.ToString();

                switch (tipo)
                {
                    case 0: 
                        newItem = new Item
                        {
                           Titulo = txtNome.Text,
                            Autor = txtAutor.Text,
                            Data = DateTime.Now,
                            Disponivel = Disponiblidadebool(),
                            Tipo = tipos,
                            BibliotecaId = _biblioteca.Id,
                        };
                        break;
                    case 1:
                        newItem = new Livro
                        {
                            Titulo = txtNome.Text,
                            Autor = txtAutor.Text,
                            Data = DateTime.Now,
                            Disponivel = Disponiblidadebool(),
                            Tipo = tipos,
                            ISBN = Convert.ToInt32(txtISBN.Text),
                            Genero = txtGenero.Text,
                            BibliotecaId = _biblioteca.Id,
                        };
                        break;
                    case 2:
                        newItem = new Revista
                        {
                            Titulo = txtNome.Text,
                            Autor = txtAutor.Text,
                            Data = DateTime.Now,
                            Disponivel = Disponiblidadebool(),
                            Tipo= cmbItem.SelectedText,
                            Edicao = txtEdicao.Text,
                            Volume = txtVolume.Text,
                            Periodicidade = txtPeriodicidade.Text,
                            Editora = txtEditora.Text,
                            BibliotecaId = _biblioteca.Id,

                        };
                        break;
                    case 3: 
                        newItem = new ArtigoCientifico
                        {
                            Titulo = txtNome.Text,
                            Autor = txtAutor.Text,
                            Data = DateTime.Now,
                            Disponivel = Disponiblidadebool(),
                            Tipo= tipos,
                            DOI = txtDOI.Text,
                            BibliotecaId = _biblioteca.Id,
                        };
                        break;
                    default:
                        MessageBox.Show("Selecione um tipo de item válido.");
                        return;
                }


                DialogResult yes = MessageBox.Show("Você tem certeza que deseja salvar esse usuario?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DialogResult.Yes == yes)
                {
                    if (_item == null ||_item.Id < 1)
                    {
                        _repository.Create(newItem);
                        MessageBox.Show($"Obrigado, {newItem.Titulo} foi registrado(a) com sucesso", "Registro Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        

                    }
                    else
                    {
                        _item.Id = newItem.Id;
                        _repository.Update(newItem);

                        MessageBox.Show($"Obrigado, {newItem.Titulo} foi Atualizado com sucesso", "Atualização Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        

                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar item: {ex.Message}");
            }
        }

        private  bool Disponiblidadebool()
        {
            if (cmbDisponibilidade.SelectedItem.ToString() == "Sim")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txtISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Impede a digitação do caractere
            }
        }
    }
}
