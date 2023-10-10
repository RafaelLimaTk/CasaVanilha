using CasaVanilha.Application.Interfaces;
using CasaVanilha.Application.Mappings;
using CasaVanilha.Application.Services;
using CasaVanilha.Domain.Interfaces;
using CasaVanilha.Infra.Data.Context;
using CasaVanilha.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CasaVanilha.Infra.IoC;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection Services,
       IConfiguration configuration)
    {
        Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(
                configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly(typeof(ApplicationDbContext)
                    .Assembly.FullName)));

        Services.AddScoped<IProductRepository, ProductRepository>();
        Services.AddScoped<IOrderRepository, OrderRepository>();
        Services.AddScoped<IOrderItemRepository, OrderItemRepository>();
        Services.AddScoped<ISaleRepository, SaleRepository>();
        Services.AddScoped<ICommandRepository, CommandRepository>();

        Services.AddScoped<IProductService, ProductService>();
        Services.AddScoped<IOrderService, OrderService>();
        Services.AddScoped<IOrderItemService, OrderItemService>();
        Services.AddScoped<ISaleService, SaleService>();
        Services.AddScoped<ICommandService, CommandService>();

        Services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

        return Services;
    }
}
