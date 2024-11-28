using CleanDocker.Domain.Entities;
using CleanDocker.Domain.Repoitories;
using CleanDocker.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CleanDocker.Infrastructure.Repositories
{
    internal class ProductRepository(ProductDbContext productDbContext) : IProductRepository
    {
        public async Task<IEnumerable<Product>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await productDbContext.Products.ToListAsync(cancellationToken);
        }

        public async Task<Product> AddProductAsync(Product product,CancellationToken cancellationToken)
        {
            await productDbContext.AddAsync(product,cancellationToken);
            await productDbContext.SaveChangesAsync(cancellationToken);
            return product;

        }
    }
}
