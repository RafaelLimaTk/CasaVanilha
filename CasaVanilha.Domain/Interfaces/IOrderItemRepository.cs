using CasaVanilha.Domain.Entities;
using CasaVanilha.Domain.Interfaces.Base;

namespace CasaVanilha.Domain.Interfaces;

public interface IOrderItemRepository : IRepository<OrderItem>
{
    IEnumerable<OrderItem> GetProductsByOrderId(Guid orderId);
    Task DeleteByOrderIdAndProductId(Guid orderId, Guid productId);
}
