using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Tipo { get; set; }
        public DateTime Data { get; set; }
        public bool Disponivel { get; set; }

        public Biblioteca Biblioteca { get; set; }
        public int BibliotecaId { get; set; }

        public List<Emprestimo> Emprestimos { get; set; } = new List<Emprestimo>();


    }
}
