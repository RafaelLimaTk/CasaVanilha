using CasaVanilha.Domain.Entities;
using CasaVanilha.Domain.Interfaces.Base;

namespace CasaVanilha.Domain.Interfaces;

public interface IOrderRepository : IRepository<Order>
{
    Task<Order> GetOpenOrderAsync();
}
