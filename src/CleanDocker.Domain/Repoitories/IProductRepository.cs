using CleanDocker.Domain.Entities;

namespace CleanDocker.Domain.Repoitories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync(CancellationToken cancellationToken);
        Task<Product> AddProductAsync(Product product, CancellationToken cancellationToken);
    }
}
