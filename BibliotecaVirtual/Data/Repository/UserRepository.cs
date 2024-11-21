using BibliotecaVirtual.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Data.Repository
{
    public class UserRepository : RepositoryBase
    {
        private AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public User AuthenticaUser(NetworkCredential credential)
        {
            User user = null;
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select * from [Users] where [email]=@Email and [password]=@Password";
                command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = credential.UserName;
                command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = credential.Password;
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user = new User
                        {
                            Id = (int)reader["Id"],
                            Name = reader["Name"].ToString(),
                            Email = reader["Email"].ToString(),
                            Password = reader["Password"].ToString()
                        };
                    }
                }
            }
            return user;
        }

        public User Create (User newUser)
        {
            try
            {
                _context.Users.Add(newUser);
                _context.SaveChanges();
                return newUser;
            }
            catch (Exception e)
            {

                throw new Exception($"Erro no Banco ao adicionar o usuario: {e.Message}", e);
            }
            
        }

        public  bool Delete(int id)
        {
            try
            {
                var user =  _context.Users.Find(id);

                if (user == null)
                {
                    throw new ArgumentException("Usuario não encontrado");
                }

                _context.Users.Remove(user);
                  _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao deletar o usuario: {e.Message}", e);
            }
        }

        public User Update(User user)
        {
            try
            {
                var userUp =  _context.Users.FirstOrDefault(x => x.Id == user.Id);

                if (userUp is null)
                {
                    throw new ArgumentException("Usuario não encontrado");
                }



                userUp.Email = user.Email;
                userUp.Password = user.Password;
                userUp.Name = user.Name;


                _context.Users.Update(userUp);
                _context.SaveChanges();
                return userUp;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao editar o usuario: {e.Message}", e);
            }
        }

        public List<User> GetAllUser()
        {
            try
            {
                return  _context.Users.ToList();
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar todos os usuarios: {e.Message}", e);
            }
        }

        public User GetById(int id)
        {
            try
            {
                var user =  _context.Users.Find(id);

                if (user is null)
                {
                    throw new ArgumentException("Usuario não encontrado");
                }

                return user;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar o usuario: {e.Message}", e);
            }
        }

        public User GetByIdEmail(string email)
        {
            try
            {
                var user =  _context.Users.FirstOrDefault(u => u.Email == email);

                return user;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar o usuario por email: {e.Message}", e);
            }
        }
    }
}
