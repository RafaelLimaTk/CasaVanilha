using CasaVanilha.Domain.Entities;
using CasaVanilha.Domain.Interfaces;
using CasaVanilha.Infra.Data.Context;
using CasaVanilha.Infra.Data.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace CasaVanilha.Infra.Data.Repositories;

public class OrderItemRepository : Repository<OrderItem>, IOrderItemRepository
{
    public OrderItemRepository(ApplicationDbContext context) : base(context)
    {
    }

    public IEnumerable<OrderItem> GetProductsByOrderId(Guid orderId)
    {
        return Entities
        .Include(oi => oi.Product)
        .Where(oi => oi.OrderId == orderId)
        .ToList();
    }
}
