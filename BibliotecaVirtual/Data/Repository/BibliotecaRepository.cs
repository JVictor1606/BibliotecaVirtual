using BibliotecaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Data.Repository
{
    public class BibliotecaRepository
    {
        string conex = @"Server=DESKTOP-UH1HBMK\SQLEXPRESS;Database=ClaudBook;User Id=sa;Password=jvictor10;TrustServerCertificate=True;";
        private readonly User _user;
        private readonly AppDbContext _context;

        public BibliotecaRepository(AppDbContext context)
        {
            _context = context;
        }

        public Biblioteca Create(Biblioteca newBibli)
        {
            try
            {
                _context.Bibliotecas.Add(newBibli);
                _context.SaveChanges();
                return newBibli;
            }
            catch (Exception e)
            {

                throw new Exception($"Erro no Banco ao adicionar a Biblioteca: {e.Message}", e);
            }

        }

        public bool Delete(int id)
        {
            try
            {
                var bi = _context.Bibliotecas.Find(id);

                if (bi == null)
                {
                    throw new ArgumentException("Biblioteca não encontrado");
                }

                _context.Bibliotecas.Remove(bi);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao deletar a Biblioteca: {e.Message}", e);
            }
        }

        public Biblioteca Update(Biblioteca bi)
        {
            try
            {
                var biUp = _context.Bibliotecas.FirstOrDefault(x => x.Id == bi.Id);

                if (biUp is null)
                {
                    throw new ArgumentException("Biblioteca não encontrado");
                }



                biUp.Nome = bi.Nome;
                biUp.Telefone = bi.Nome;
                biUp.Descricao = bi.Nome;
                biUp.User = bi.User;
                biUp.UserId = bi.UserId;
                biUp.Itens = bi.Itens;


                _context.Bibliotecas.Update(biUp);
                _context.SaveChanges();
                return biUp;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao editar a Biblioteca: {e.Message}", e);
            }
        }

        public List<Biblioteca> GetAllBibliotecas()
        {
            try
            {
                return _context.Bibliotecas.ToList();
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar todos as Bibliotecas: {e.Message}", e);
            }
        }

        public Biblioteca GetById(int id)
        {
            try
            {
                var bi = _context.Bibliotecas.Find(id);

                if (bi is null)
                {
                    throw new ArgumentException("Biblioteca não encontrado");
                }

                return bi;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar a Biblioteca: {e.Message}", e);
            }
        }

        public List<Biblioteca> Pesquisar(int tipoPesquisa, string textoPesquisa)
        {
            using (var context = new AppDbContext())
            {
                IQueryable<Biblioteca> query = context.Bibliotecas;

                if (tipoPesquisa == 0)
                {
                    query = query.Where(b => Convert.ToString(b.Id).Contains(textoPesquisa));
                }
                if (tipoPesquisa == 1)
                {
                    query = query.Where(b => b.Nome.Contains(textoPesquisa));
                }

                return query.ToList();
            }
        }
    }
}
