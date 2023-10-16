using bibliotecaVirtual.Models;
using Microsoft.EntityFrameworkCore;

namespace bibliotecaVirtual.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Autor> autor { get; set; }
        public DbSet<Editora> editora { get; set; }
        public DbSet<Livro> livro { get; set; }
    }
}
