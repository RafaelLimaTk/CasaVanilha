using AutoMapper;
using CasaVanilha.Application.DTOs;
using CasaVanilha.Application.Interfaces;
using CasaVanilha.Application.Services.Base;
using CasaVanilha.Domain.Entities;
using CasaVanilha.Domain.Interfaces;
using CasaVanilha.Domain.Interfaces.Base;

namespace CasaVanilha.Application.Services;

public class OrderService : Service<OrderDto, Order>, IOrderService
{
    private readonly IOrderRepository _orderRepository;
    private readonly IProductRepository _productRepository;
    public OrderService(IMapper mapper, IRepository<Order> repository,
        IOrderRepository orderRepository, IProductRepository productRepository) : base(mapper, repository)
    {
        _orderRepository = orderRepository;
        _productRepository = productRepository;
    }

    public async Task<Guid> AddOrderItemAsync(OrderItemDto orderItemDto)
    {
        var order = await _orderRepository.GetOpenOrderAsync();
        if (order == null)
        {
            order = new Order(DateTime.UtcNow, "Open");
            await _orderRepository.CreateAsync(order);
        }

        var product = await _productRepository.GetByIdAsync(orderItemDto.ProductId);
        var orderItem = new OrderItem(product, 1, product.UnitPrice);
        order.AddOrderItem(orderItem);

        //await _orderRepository.UpdateAsync(order);

        return order.Id;
    }

    public async Task RemoveOrderItemAsync(Guid orderId, Guid productId)
    {
        var order = await _orderRepository.GetByIdAsync(orderId);
        if (order == null)
            throw new InvalidOperationException("Order not found.");

        var orderItem = order.OrderItems.FirstOrDefault(oi => oi.Product.Id == productId);
        if (orderItem == null)
            throw new InvalidOperationException("Order item not found.");

        order.RemoveOrderItem(orderItem);
        await _orderRepository.UpdateAsync(order);
    }
}
