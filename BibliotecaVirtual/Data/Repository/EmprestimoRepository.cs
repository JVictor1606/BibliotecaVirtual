using BibliotecaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Data.Repository
{
    public class EmprestimoRepository
    {
        private readonly AppDbContext _context;
        public EmprestimoRepository(AppDbContext context) 
        {
            _context = context;
        }

        public void Create(Emprestimo emprestimo)
        {
            _context.Emprestimos.Add(emprestimo);
            _context.SaveChanges();
        }

        public List<Emprestimo> GetAllEmprestimos()
        {
            return _context.Emprestimos.ToList();
        }

        public List<User> PesquiseUser(string pesquisa)
        {
            return _context.Users
                           .Where(u => u.Name.Contains(pesquisa) || u.Id.ToString() == pesquisa)
                           .ToList();
        }
    }
}
