using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Models
{
    public class Revista : Item
    {
        public string Edicao { get; set; }
        public string Volume { get; set; }
        public string Periodicidade { get; set; }
        public string Editora { get; set; }
    }

}
