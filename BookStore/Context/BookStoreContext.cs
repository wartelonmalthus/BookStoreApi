using BookStore.Mapping;
using BookStoreDomain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Context
{
    public class BookStoreContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Autor> Autores { set; get; }

        public DbSet<Livro> Livros { get; set; }

        protected override void OnConfiguring(
           DbContextOptionsBuilder optionsBuilder)
          => optionsBuilder.UseSqlite(connectionString: "DataSource=app.db;Cache=Shared");



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AutorMap());
            modelBuilder.ApplyConfiguration(new CategoriaMap());
            modelBuilder.ApplyConfiguration(new LivroMap());
        }


    }
}
