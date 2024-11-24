using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Models
{
    public class Emprestimo
    {
        public int Id { get; set; }

        public int ItemId { get; set; }
        public Item Item { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public User user { get; set; }

        public DateTime? DataEmprestimo { get; set; }
        public DateTime? DataDevolucao { get; set; }

        public bool Concluido { get; set; }
    }
}
