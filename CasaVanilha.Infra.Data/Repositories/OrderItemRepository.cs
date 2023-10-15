using CasaVanilha.Domain.Entities;
using CasaVanilha.Domain.Interfaces;
using CasaVanilha.Infra.Data.Context;
using CasaVanilha.Infra.Data.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace CasaVanilha.Infra.Data.Repositories;

public class OrderItemRepository : Repository<OrderItem>, IOrderItemRepository
{
    private readonly ApplicationDbContext _context;
    public OrderItemRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    public IEnumerable<OrderItem> GetProductsByOrderId(Guid orderId)
    {
        return Entities
        .Include(oi => oi.Product)
        .Where(oi => oi.OrderId == orderId)
        .ToList();
    }

    public async Task DeleteByOrderIdAndProductId(Guid orderId, Guid productId)
    {
        var orderItem = Entities
            .FirstOrDefault(oi => oi.OrderId == orderId && oi.ProductId == productId);

        if (orderItem != null)
        {
            Entities.Remove(orderItem);
            await _context.SaveChangesAsync();
        }
    }
}
