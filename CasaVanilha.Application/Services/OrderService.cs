using AutoMapper;
using CasaVanilha.Application.DTOs;
using CasaVanilha.Application.Factories;
using CasaVanilha.Application.Interfaces;
using CasaVanilha.Application.Services.Base;
using CasaVanilha.Domain.Entities;
using CasaVanilha.Domain.Interfaces;

namespace CasaVanilha.Application.Services;

public class OrderService : Service<OrderDto, Order>, IOrderService
{
    private readonly IOrderRepository _orderRepository;
    private readonly IProductService _productService;
    private readonly IMapper _mapper;

    public OrderService(IOrderRepository orderRepository, IProductService productService, IMapper mapper)
        : base(mapper, orderRepository)
    {
        _orderRepository = orderRepository;
        _productService = productService;
        _mapper = mapper;
    }

    public async Task<Order> GetOpenOrderAsync()
    {
        return await _orderRepository.GetOpenOrderAsync();
    }

    public async Task CloseOrderAsync(Guid orderId)
    {
        await _orderRepository.CloseOrderAsync(orderId);
    }

    public async Task AddOrderItemAsync(Guid orderId, OrderItemDto orderItemDto)
    {
        var orderItem = _mapper.Map<OrderItem>(orderItemDto);
        var order = await _orderRepository.GetByIdAsync(orderId);
        if (order == null)
            throw new Exception("Order not found.");

        orderItem.AssignOrder(order);

        orderItem.AssignOrderId(orderId);
        await _orderRepository.AddOrderItemAsync(orderId, orderItem);
    }

    public async Task<Guid> CreateOrderAsync()
    {
        var newOrder = OrderFactory.CreateNewOrder(DateTime.Now, "Nova");

        await _orderRepository.CreateAsync(newOrder);

        return newOrder.Id;
    }
}
