using BibliotecaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Data.Repository
{
    public class ItemRepository
    {
        private readonly Biblioteca _biblioteca;
        private readonly AppDbContext _context;

        public ItemRepository(AppDbContext context)
        {
            _context = context;
        }

    }
}
