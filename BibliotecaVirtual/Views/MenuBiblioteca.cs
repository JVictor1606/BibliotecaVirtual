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
        private readonly ItemRepository _repository;
        private Biblioteca _biblioteca;
        private User _user;
        public MenuBiblioteca(User user, Biblioteca biblioteca)
        {
            InitializeComponent();
            _biblioteca = biblioteca;
            _user = user;
            _repository = new ItemRepository(new AppDbContext);
            
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

        }
    }
}
