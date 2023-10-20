using CasaVanilha.Domain.Entities;
using CasaVanilha.Domain.Interfaces.Base;

namespace CasaVanilha.Domain.Interfaces;

public interface IOrderRepository : IRepository<Order>
{
    Task<Order> GetOpenOrderAsync();
    Task CloseOrderAsync(Guid orderId);
    Task AddOrderItemAsync(Guid orderId, OrderItem orderItem);
    Task<Order> GetOrderWithItemsByIdAsync(Guid orderId);
    IEnumerable<Order> GetOrdersByStatus();
    IUnitOfWork UnitOfWork { get; }
}
