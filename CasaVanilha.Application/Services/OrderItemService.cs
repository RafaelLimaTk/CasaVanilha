using AutoMapper;
using CasaVanilha.Application.DTOs;
using CasaVanilha.Application.Interfaces;
using CasaVanilha.Application.Services.Base;
using CasaVanilha.Domain.Entities;
using CasaVanilha.Domain.Interfaces.Base;

namespace CasaVanilha.Application.Services;

public class OrderItemService : Service<OrderItemDto, OrderItem>, IOrderItemService
{
    public OrderItemService(IMapper mapper, IRepository<OrderItem> repository) : base(mapper, repository)
    {
    }
}
