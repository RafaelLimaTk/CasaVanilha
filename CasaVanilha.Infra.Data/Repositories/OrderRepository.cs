using CasaVanilha.Domain.Entities;
using CasaVanilha.Domain.Interfaces;
using CasaVanilha.Infra.Data.Context;
using CasaVanilha.Infra.Data.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace CasaVanilha.Infra.Data.Repositories;

public class OrderRepository : Repository<Order>, IOrderRepository
{
    public OrderRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<Order> GetOpenOrderAsync()
        => await Entities
            .Include(o => o.OrderItems)
            .Where(o => o.Status == "Open")
            .FirstOrDefaultAsync();
}
