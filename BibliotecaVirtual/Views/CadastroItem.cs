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
        public CadastroItem()
        {
            InitializeComponent();
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
                case 0:
                    txtEditora.Enabled = true;
                    txtPeriodicidade.Enabled = true;
                    txtEdicao.Enabled = true;
                    txtVolume.Enabled = true;
                break;
                case 1:
                    txtISBN.Enabled = true;
                    txtGenero.Enabled = true;
                break ;
                case 2:
                    txtDOI.Enabled = true;
                break ;

            }
        }

        private void CadastroItem_Load(object sender, EventArgs e)
        {
            
        }
    }
}
