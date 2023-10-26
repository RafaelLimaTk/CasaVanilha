using CasaVanilha.Application.DTOs;
using CasaVanilha.Application.Interfaces.Base;
using CasaVanilha.Domain.Entities;
using System.Drawing.Printing;

namespace CasaVanilha.Application.Interfaces;

public interface IOrderService : IService<OrderDto, Order>
{
    Task<Order> GetOpenOrderAsync();
    Task CloseOrderAsync(Guid orderId);
    Task AddOrderItemAsync(Guid orderId, OrderItemDto orderItemDto);
    IEnumerable<OrderDto> GetOrdersByStatus();
    Task<Guid> CreateOrderAsync();
    IEnumerable<OrderDto> GetAllOrdersWithItems();
    IEnumerable<OrderDto> GetAllOrdersWithItems(int currentPage, int pageSize);
}
