
using Microsoft.EntityFrameworkCore;
using VeraoSorvete.Models;

namespace VeraoSorvete.Content
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Sorvete> Sorvetes { get; set; }
    }
}
