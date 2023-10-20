using CasaVanilha.Application.DTOs;
using CasaVanilha.Application.Interfaces.Base;
using CasaVanilha.Domain.Entities;

namespace CasaVanilha.Application.Interfaces;

public interface IOrderItemService : IService<OrderItemDto, OrderItem>
{
    IEnumerable<OrderItem> GetProductsByOrderId(Guid orderId);
    Task DeleteProductFromOrder(Guid orderId, Guid productId);
    Task<bool> UpdateOrderItemQuantityAsync(Guid orderId, Guid productId, int quantity);
    IEnumerable<OrderItemDto> GetClosedOrderByProdcut();
}
