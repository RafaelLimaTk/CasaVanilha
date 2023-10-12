using CasaVanilha.Application.DTOs;
using CasaVanilha.Application.Interfaces.Base;
using CasaVanilha.Domain.Entities;

namespace CasaVanilha.Application.Interfaces;

public interface IOrderService : IService<OrderDto, Order>
{
    Task<Guid> AddOrderItemAsync(OrderItemDto orderItemDto);
    Task RemoveOrderItemAsync(Guid orderId, Guid productId);
}
