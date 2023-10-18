using AutoMapper;
using CasaVanilha.Application.Interfaces;
using CasaVanilha.Application.Interfaces.Base;
using CasaVanilha.Application.Mappings;
using CasaVanilha.Application.Services;
using CasaVanilha.Application.Services.Base;
using CasaVanilha.Domain.Interfaces;
using CasaVanilha.Domain.Interfaces.Base;
using CasaVanilha.Infra.Data.Context;
using CasaVanilha.Infra.Data.Repositories;
using CasaVanilha.Infra.Data.Repositories.Base;
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

        Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        Services.AddScoped<IProductRepository, ProductRepository>();
        Services.AddScoped<IOrderRepository, OrderRepository>();
        Services.AddScoped<IOrderItemRepository, OrderItemRepository>();
        Services.AddScoped<ICommandRepository, CommandRepository>();

        Services.AddScoped(typeof(IService<,>), typeof(Service<,>));
        Services.AddScoped<IProductService, ProductService>();
        Services.AddScoped<IOrderService, OrderService>();
        Services.AddScoped<IOrderItemService, OrderItemService>();
        Services.AddScoped<ICommandService, CommandService>();
        Services.AddScoped<IPrinterService, PrinterService>();

        Services.AddAutoMapper(typeof(DomainToDTOMappingProfile));
        var config = new MapperConfiguration(cfg => {
            cfg.AddProfile<DomainToDTOMappingProfile>();
        });
        config.AssertConfigurationIsValid();


        return Services;
    }
}
