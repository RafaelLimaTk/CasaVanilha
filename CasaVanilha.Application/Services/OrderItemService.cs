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
    public OrderItemService(IMapper mapper, IRepository<OrderItem> repository, IOrderItemRepository orderItemRepository) : base(mapper, repository)
    {
        _orderItemRepository = orderItemRepository;
    }

    public IEnumerable<OrderItem> GetProductsByOrderId(Guid orderId)
    {
        return _orderItemRepository.GetProductsByOrderId(orderId);
    }

    public async Task DeleteProductFromOrder(Guid orderId, Guid productId)
    {
        await _orderItemRepository.DeleteByOrderIdAndProductId(orderId, productId);
    }
}
