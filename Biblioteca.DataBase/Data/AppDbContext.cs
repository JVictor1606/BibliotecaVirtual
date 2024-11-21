using BibliotecaVirtual.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.DataBase.Data
{
    public class AppDbContext :DbContext
    {
        private RepositoryBase _base;
        public AppDbContext()
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Bibliote> Bibliotecas { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Livro> Livro { get; set; }
        public DbSet<Revista> Revistas { get; set; }
        public DbSet<ArtigoCientifico> ArtigoCientificos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(_base.GetConnection());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Bibliote>()
            .HasOne(b => b.User)
            .WithMany(u => u.bibliotecas)
            .HasForeignKey(b => b.UserId);

            modelBuilder.Entity<Item>()
            .HasOne(i => i.Biblioteca)
            .WithMany(b => b.Itens)
            .HasForeignKey(i => i.BibliotecaId);

            modelBuilder.Entity<Item>()
             .HasDiscriminator<string>("ItemType")
             .HasValue<Item>("Item")
             .HasValue<Livro>("Livro")
             .HasValue<Revista>("Revista")
             .HasValue<ArtigoCientifico>("ArtigoCientifico");

        }


    }
}
