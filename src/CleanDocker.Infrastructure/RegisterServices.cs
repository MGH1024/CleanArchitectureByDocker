using CleanDocker.Domain;
using CleanDocker.Domain.Repoitories;
using CleanDocker.Infrastructure.Contexts;
using CleanDocker.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanDocker.Infrastructure
{
    public static class RegisterServices
    {
        public static void AddInfrastructureServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddTransient<IProductRepository, ProductRepository>();

            services.AddDbContext<ProductDbContext>(option =>
            {
                option.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
        }
    }
}
