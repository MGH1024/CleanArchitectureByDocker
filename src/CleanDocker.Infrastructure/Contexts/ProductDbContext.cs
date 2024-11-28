using CleanDocker.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanDocker.Infrastructure.Contexts
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
