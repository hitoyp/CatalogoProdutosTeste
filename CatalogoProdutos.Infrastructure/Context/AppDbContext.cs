using CatalogoProdutos.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CatalogoProdutos.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { } 

        public DbSet<Produtos> Produtos { get; set; }
    }
}
