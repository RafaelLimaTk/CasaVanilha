using AutoMapper;
using CasaVanilha.Application.DTOs;
using CasaVanilha.Application.Interfaces;
using CasaVanilha.Application.Services.Base;
using CasaVanilha.Domain.Entities;
using CasaVanilha.Domain.Interfaces;
using CasaVanilha.Domain.Interfaces.Base;

namespace CasaVanilha.Application.Services;

public class OrderItemService : Service<OrderItemDto, OrderItem>, IOrderItemService
{
    private readonly IOrderItemRepository _orderItemRepository;
    private readonly IOrderRepository _orderRepository;
    public OrderItemService(IMapper mapper, IRepository<OrderItem> repository, IOrderItemRepository orderItemRepository, 
        IOrderRepository orderRepository) : base(mapper, repository)
    {
        _orderItemRepository = orderItemRepository;
        _orderRepository = orderRepository;
    }

    public IEnumerable<OrderItem> GetProductsByOrderId(Guid orderId)
    {
        return _orderItemRepository.GetProductsByOrderId(orderId);
    }

    public async Task DeleteProductFromOrder(Guid orderId, Guid productId)
    {
        await _orderItemRepository.DeleteByOrderIdAndProductId(orderId, productId);
    }

    public async Task<bool> UpdateOrderItemQuantityAsync(Guid orderId, Guid productId, int quantity)
    {
        var orderItem = await _orderItemRepository.GetOrderItemAsync(orderId, productId);
        if (orderItem == null)
        {
            return false;
        }

        orderItem.UpdateQuantity(quantity);
        await _orderItemRepository.UpdateAsync(orderItem);

        return true;
    }

    public IEnumerable<OrderItemDto> GetClosedOrderByProdcut()
    {
        var closedOrders = _orderRepository.GetOrdersByStatus().ToList();
        var orderItemDtos = new List<OrderItemDto>();

        foreach (var order in closedOrders)
        {
            var orderItems = GetProductsByOrderId(order.Id);

            foreach (var item in orderItems)
            {
                var orderItemDto = new OrderItemDto
                {
                    OrderId = item.OrderId,
                    Product = new ProductDto
                    {
                        Name = item.Product.Name,
                        UnitPrice = item.Product.UnitPrice,
                    },
                    Quantity = item.Quantity
                };

                orderItemDtos.Add(orderItemDto);
            }
        }

        var groupedOrderItemDtos = orderItemDtos
        .GroupBy(x => x.Product.Name)
        .Select(g => new OrderItemDto
        {
            Product = new ProductDto
            {
                Name = g.Key,
                UnitPrice = g.First().Product.UnitPrice
            },
            Quantity = g.Sum(x => x.Quantity)
        });

        return groupedOrderItemDtos;
    }
}
