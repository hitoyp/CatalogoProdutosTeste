using CatalogoProdutos.Application.Interface;
using CatalogoProdutos.Application.Mapping;
using CatalogoProdutos.Application.Service;
using CatalogoProdutos.Domain.Interface;
using CatalogoProdutos.Infrastructure.Context;
using CatalogoProdutos.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace CatalogoProdutos.CrossCutting.Ioc
{
    public static class DependencyInjectionApi
    {
        public static IServiceCollection AddInjectionInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseInMemoryDatabase("CatalogoProdutoDB");
            }); 

            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IProdutoService, ProdutoService>();

            services.AddAutoMapper(typeof(MappingProdutoDTO));

            return services;
        }
    }
}
