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


        public Item Create(Item newItem)
        {
            try
            {
                _context.Itens.Add(newItem);
                _context.SaveChanges();
                return newItem;
            }
            catch (Exception e)
            {

                throw new Exception($"Erro no Banco ao adicionar aos Itens: {e.Message}", e);
            }

        }

        public bool Delete(int id)
        {
            try
            {
                var bi = _context.Itens.Find(id);

                if (bi == null)
                {
                    throw new ArgumentException("Item não encontrado");
                }

                _context.Itens.Remove(bi);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao deletar o Item: {e.Message}", e);
            }
        }

        public Item Update(Item updatedItem)
        {
            try
            {
                var existingItem = _context.Itens.FirstOrDefault(x => x.Id == updatedItem.Id);
                if (existingItem == null)
                {
                    throw new ArgumentException("Item não encontrado");
                }

                existingItem.Titulo = updatedItem.Titulo;
                existingItem.Autor = updatedItem.Autor;
                existingItem.Data = updatedItem.Data;
                existingItem.Disponivel = updatedItem.Disponivel;

                _context.SaveChanges();
                return existingItem;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao atualizar o Item: {e.Message}", e);
            }
        }

        public List<Item> GetAllItens()
        {
            try
            {
                return _context.Itens.ToList();
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar todos as Bibliotecas: {e.Message}", e);
            }
        }

        public Item GetById(int id)
        {
            try
            {
                var bi = _context.Itens.Find(id);

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

        public List<Item> Pesquisar(int tipoPesquisa, string textoPesquisa)
        {
            using (var context = new AppDbContext())
            {
                IQueryable<Item> query = context.Itens;

                if (tipoPesquisa == 0)
                {
                    query = query.Where(b => Convert.ToString(b.Id).Contains(textoPesquisa));
                }
                if (tipoPesquisa == 1)
                {
                    query = query.Where(b => b.Titulo.Contains(textoPesquisa));
                }

                return query.ToList();
            }
        }

        public List<Item> GetItemsByType<T>() where T : Item
        {
            try
            {
                // Valida o tipo solicitado para garantir que é um dos três esperados
                if (typeof(T) != typeof(Livro) && typeof(T) != typeof(Revista) && typeof(T) != typeof(ArtigoCientifico))
                {
                    throw new InvalidOperationException($"Tipo {typeof(T).Name} não suportado. Apenas 'Livro', 'Revista' e 'Artigo' são permitidos.");
                }

                // Filtra itens pelo tipo específico usando OfType<>
                return _context.Itens.OfType<T>().Cast<Item>().ToList();
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar itens do tipo {typeof(T).Name}: {e.Message}", e);
            }
        }

    }
}
