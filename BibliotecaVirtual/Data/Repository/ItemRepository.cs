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
                _context.Items.Add(newItem);
                _context.SaveChanges();
                return newItem;
            }
            catch (Exception e)
            {
                Console.WriteLine(($"Erro no Banco ao adicionar aos Itens: {e.Message} \n {e.StackTrace}", e));


                throw new Exception($"Erro no Banco ao adicionar aos Itens: {e.Message} \n {e.StackTrace}", e);
            }

        }

        public bool Delete(int id)
        {
            try
            {
                var bi = _context.Items.Find(id);

                if (bi == null)
                {
                    throw new ArgumentException("Item não encontrado");
                }

                _context.Items.Remove(bi);
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
                var existingItem = _context.Items.FirstOrDefault(x => x.Id == updatedItem.Id);
                if (existingItem == null)
                {
                    throw new ArgumentException("Item não encontrado");
                }

                existingItem.Titulo = updatedItem.Titulo;
                existingItem.Autor = updatedItem.Autor;
                existingItem.Data = updatedItem.Data;
                existingItem.Disponivel = updatedItem.Disponivel;

                switch (updatedItem)
                {
                    case Livro livro:
                        var existingLivro = existingItem as Livro;
                        if (existingLivro != null)
                        {
                            existingLivro.ISBN = livro.ISBN;
                            existingLivro.Genero = livro.Genero;
                        }
                        break;

                    case Revista revista:
                        var existingRevista = existingItem as Revista;
                        if (existingRevista != null)
                        {
                            existingRevista.Edicao = revista.Edicao;
                            existingRevista.Volume = revista.Volume;
                            existingRevista.Periodicidade = revista.Periodicidade;
                            existingRevista.Editora = revista.Editora;
                        }
                        break;

                    case ArtigoCientifico artigo:
                        var existingArtigo = existingItem as ArtigoCientifico;
                        if (existingArtigo != null)
                        {
                            existingArtigo.DOI = artigo.DOI;
                        }
                        break;

                    default:
                        throw new ArgumentException("Tipo de item não suportado");
                }

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
                return _context.Items.ToList();
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar todos os Itens: {e.Message}", e);
            }
        }

        public Item GetById(int id)
        {
            try
            {
                var bi = _context.Items.Find(id);

                if (bi is null)
                {
                    throw new ArgumentException("item não encontrado");
                }

                return bi;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar o Item: {e.Message}", e);
            }
        }

        public List<Item> Pesquisar(int tipoPesquisa, string textoPesquisa)
        {
            using (var context = new AppDbContext())
            {
                IQueryable<Item> query = context.Items;

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
                if (typeof(T) != typeof(Livro) && typeof(T) != typeof(Revista) && typeof(T) != typeof(ArtigoCientifico))
                {
                    throw new InvalidOperationException($"Tipo {typeof(T).Name} não suportado. Apenas 'Livro', 'Revista' e 'Artigo' são permitidos.");
                }

                return _context.Items.OfType<T>().Cast<Item>().ToList();
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar itens do tipo {typeof(T).Name}: {e.Message}", e);
            }
        }

        public List<Item> GetItemByLivro()
        {
            return _context.Items.OfType<Livro>().Select(l => (Item)l).ToList();

        }

        public List<Item> GetItemByRevista()
        {
            return _context.Items.OfType<Revista>().Select(l => (Item)l).ToList();

        }

        public List<Item> GetItemByArtigo()
        {
            return _context.Items.OfType<ArtigoCientifico>().Select(l => (Item)l).ToList();

        }


    }
}
