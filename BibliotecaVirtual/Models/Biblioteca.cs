using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Models
{
    public class Biblioteca
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Telefone { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }

        public List<Item> Itens { get; set; } = new List<Item>();

        
    }
}
