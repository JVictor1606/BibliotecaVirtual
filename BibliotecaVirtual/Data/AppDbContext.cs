using BibliotecaVirtual.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Data
{
    public class AppDbContext : DbContext
    {

        private RepositoryBase _base;
        public AppDbContext()
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Biblioteca> Bibliotecas { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Livro> Livro { get; set; }
        public DbSet<Revista> Revistas { get; set; }
        public DbSet<ArtigoCientifico> ArtigoCientificos { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=DESKTOP-UH1HBMK\\SQLEXPRESS;Database=ClaudBook;User Id=sa;Password=jvictor10;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Biblioteca>()
            .HasOne(b => b.User)
            .WithMany(u => u.Bibliotecas)
            .HasForeignKey(b => b.UserId);

            modelBuilder.Entity<Item>()
            .HasOne(i => i.Biblioteca)
            .WithMany(b => b.Itens)
            .HasForeignKey(i => i.BibliotecaId);

            modelBuilder.Entity<Item>()
             .HasDiscriminator<ItemType>("ItemType")
             .HasValue<Item>(ItemType.Item)
             .HasValue<Livro>(ItemType.Livro)
             .HasValue<Revista>(ItemType.Revista)
             .HasValue<ArtigoCientifico>(ItemType.ArtigoCientifico);


            modelBuilder.Entity<Emprestimo>()
                .HasOne(e => e.Item)
                .WithMany(i => i.Emprestimos)
                .HasForeignKey(e => e.ItemId);

            modelBuilder.Entity<Emprestimo>()
                .HasOne(e => e.User)
                .WithMany(u => u.Emprestimos)
                .HasForeignKey(e => e.UserId);

        }

    }
}
