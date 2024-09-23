// Isabelly Barbosa Gonçalves CB3021467

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Command
{
    public class LibraryDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conn = "server=localhost;database=Library;user=root;password=12345678";

            optionsBuilder.UseMySql(conn, ServerVersion.AutoDetect(conn));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasMany(b => b.Authors).WithMany();
        }
    }
}
