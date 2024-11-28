using CleanDocker.Application.Dtos;
using CleanDocker.Domain.Entities;

namespace CleanDocker.Application.Contarcts
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProductAsync(CancellationToken cancellationToken);
        Task AddProductAsync(ProductDto productDto, CancellationToken cancellationToken);
    }
}
