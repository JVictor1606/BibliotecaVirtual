using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Models
{
    public enum ItemType
    {
        [Description("Item Normal")]
        Item,

        [Description("Livro")]
        Livro,

        [Description("Revista")]
        Revista,

        [Description("Artigo Cientifico")]
        ArtigoCientifico

    }
}
