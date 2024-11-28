using CleanDocker.Application.Contarcts;
using CleanDocker.Application.Dtos;
using CleanDocker.Domain.Entities;
using CleanDocker.Domain.Repoitories;

namespace CleanDocker.Application.Services
{
    public class ProductService(IProductRepository productRepository) : IProductService
    {

        public async Task AddProductAsync(ProductDto productDto, CancellationToken cancellationToken)
        {
            var product  = new Product 
            { 
                Name = productDto.Name ,   
                Description = productDto.Description
            };

            await productRepository.AddProductAsync(product, cancellationToken);
        }

        public async Task<IEnumerable<Product>> GetAllProductAsync(CancellationToken cancellationToken)
        {
            return await productRepository.GetAllAsync(cancellationToken);
        }
    }
}
