using CasaVanilha.Application.DTOs;
using CasaVanilha.Application.Interfaces.Base;
using CasaVanilha.Domain.Entities;

namespace CasaVanilha.Application.Interfaces;

public interface IOrderService : IService<OrderDto, Order>
{
    Task<Order> GetOpenOrderAsync();
    Task CloseOrderAsync(Guid orderId);
    Task AddOrderItemAsync(Guid orderId, OrderItemDto orderItemDto);
    IEnumerable<OrderDto> GetOrdersByStatus();
    Task<Guid> CreateOrderAsync();
}
