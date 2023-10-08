using CasaVanilha.Domain.Entities;
using CasaVanilha.Domain.Interfaces;
using CasaVanilha.Infra.Data.Context;
using CasaVanilha.Infra.Data.Repositories.Base;

namespace CasaVanilha.Infra.Data.Repositories;

public class OrderItemRepository : Repository<OrderItem>, IOrderItemRepository
{
    public OrderItemRepository(ApplicationDbContext context) : base(context)
    {
    }
}
