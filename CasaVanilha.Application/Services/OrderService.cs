using AutoMapper;
using CasaVanilha.Application.DTOs;
using CasaVanilha.Application.Factories;
using CasaVanilha.Application.Interfaces;
using CasaVanilha.Application.Services.Base;
using CasaVanilha.Domain.Entities;
using CasaVanilha.Domain.Interfaces;
using System.Drawing.Printing;

namespace CasaVanilha.Application.Services;

public class OrderService : Service<OrderDto, Order>, IOrderService
{
    private readonly IOrderRepository _orderRepository;
    private readonly IOrderItemService _orderItemService;
    private readonly IProductService _productService;
    private readonly IPrinterService _printerService;
    private readonly IMapper _mapper;

    public OrderService(IOrderRepository orderRepository, IProductService productService,
        IMapper mapper, IOrderItemService orderItemService, IPrinterService printerService)
        : base(mapper, orderRepository)
    {
        _orderRepository = orderRepository;
        _productService = productService;
        _orderItemService = orderItemService;
        _printerService = printerService;
        _mapper = mapper;
    }

    public async Task<Order> GetOpenOrderAsync()
    {
        return await _orderRepository.GetOpenOrderAsync();
    }

    public async Task CloseOrderAsync(Guid orderId)
    {
        await _orderRepository.CloseOrderAsync(orderId);

        var orderItems = _orderItemService.GetProductsByOrderId(orderId);

        await _productService.UpdateStockAsync(orderItems.ToList());

        //_printerService.PrintOrderItems(orderItems.ToList());
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

    public IEnumerable<OrderDto> GetOrdersByStatus()
    {
        var ordersByStatus = _orderRepository.GetOrdersByStatus().ToList();
        var ordersByStatusDto = _mapper.Map<IEnumerable<OrderDto>>(ordersByStatus);

        return ordersByStatusDto;
    }

    public IEnumerable<OrderDto> GetAllOrdersWithItems()
    {
        var orders = _orderRepository.GetAllOrdersWithOrderItems().ToList();

        var orderDtos = _mapper.Map<IEnumerable<OrderDto>>(orders);
        return orderDtos;
    }

    public IEnumerable<OrderDto> GetAllOrdersWithItems(int currentPage, int pageSize)
    {
        var groupedOrderDto = GetAllOrdersWithItems();

        return groupedOrderDto.Skip((currentPage - 1) * pageSize).Take(pageSize);
    }
}
