using AutoMapper;
using CasaVanilha.Application.DTOs;
using CasaVanilha.Application.Interfaces;
using CasaVanilha.Application.Services.Base;
using CasaVanilha.Domain.Entities;
using CasaVanilha.Domain.Interfaces.Base;

namespace CasaVanilha.Application.Services;

public class OrderService : Service<OrderDto, Order>, IOrderService
{
    public OrderService(IMapper mapper, IRepository<Order> repository) : base(mapper, repository)
    {
    }
}
