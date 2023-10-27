using CasaVanilha.Domain.Entities;
using CasaVanilha.Domain.Interfaces;
using CasaVanilha.Infra.Data.Context;
using CasaVanilha.Infra.Data.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace CasaVanilha.Infra.Data.Repositories;

public class OrderRepository : Repository<Order>, IOrderRepository
{
    private readonly ApplicationDbContext _context;
    private readonly IOrderItemRepository _orderItemRepository;
    public OrderRepository(ApplicationDbContext context, IOrderItemRepository orderItemRepository) : base(context)
    {
        _context = context;
        _orderItemRepository = orderItemRepository;
    }

    public IUnitOfWork UnitOfWork => new CasaVanilha.Infra.Data.UnitOfWork.UnitOfWork(_context);

    public async Task<Order> GetOpenOrderAsync()
     => await Entities
        .Include(o => o.OrderItems)
        .Where(o => o.Status == "Nova")
        .FirstOrDefaultAsync();

    public async Task AddOrderItemAsync(Guid orderId, OrderItem orderItem)
    {
        var orderItemSave = new OrderItem(orderItem.Id, orderId, orderItem.ProductId, orderItem.Quantity);

        await _orderItemRepository.CreateAsync(orderItemSave);
    }

    public async Task CloseOrderAsync(Guid orderId, string observation)
    {
        var order = await Entities.FindAsync(orderId);
        if (order != null)
        {
            order.Close();
            order.SetObservation(observation);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<Order> GetOrderWithItemsByIdAsync(Guid orderId)
    {
        return await Entities
            .Include(o => o.OrderItems)
            .FirstOrDefaultAsync(o => o.Id == orderId);
    }
    public void Update(Order order)
    {
        _context.Entry(order).State = EntityState.Modified;
    }

    public IEnumerable<Order> GetOrdersByStatus()
    {
        return Entities
            .Where(o => o.Status == "Fechada").ToList();
    }

    public IEnumerable<Order> GetAllOrdersWithOrderItems()
    {
        return Entities
            .Include (o => o.OrderItems)
            .ThenInclude(oi => oi.Product)
            .OrderByDescending(o => o.OrderDateTime)
            .ToList();
    }
}
