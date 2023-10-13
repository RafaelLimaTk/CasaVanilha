using CasaVanilha.Domain.Entities.Base;

namespace CasaVanilha.Domain.Entities;

public class OrderItem : EntityBase
{
    public Guid OrderId { get; private set; }
    public Order Order { get; private set; }

    public Guid ProductId { get; private set; }
    public Product Product { get; private set; }
    public int Quantity { get; private set; }

    public OrderItem() { }
    public OrderItem(Guid id, Guid orderId, Guid productId, int quantity)
    {
        Id = id;
        OrderId = orderId;
        ProductId = productId;
        Quantity = quantity;
    }

    private void SetQuantity(int quantity)
    {
        if (quantity <= 0)
            throw new ArgumentException("Quantity must be greater than zero", nameof(quantity));
        Quantity = quantity;
    }

    public void AddQuantity(int quantity)
    {
        if (quantity <= 0)
            throw new ArgumentOutOfRangeException(nameof(quantity), "A quantidade deve ser maior que zero.");

        Quantity += quantity;
    }

    public OrderItem(Guid productId, int quantity)
    {
        if (productId == Guid.Empty)
            throw new ArgumentException("ProductId cannot be empty.", nameof(productId));

        if (quantity <= 0)
            throw new ArgumentOutOfRangeException(nameof(quantity), "Quantity must be greater than zero.");

        ProductId = productId;
        Quantity = quantity;
    }

    public void UpdateQuantity(int newQuantity)
    {
        if (newQuantity <= 0)
            throw new ArgumentOutOfRangeException(nameof(newQuantity), "Quantity must be greater than zero.");

        Quantity = newQuantity;
    }

    public void AssignOrder(Order order)
    {
        Order = order ?? throw new ArgumentNullException(nameof(order));
        OrderId = order.Id;
    }

    public void AssignOrderId(Guid orderId)
    {
        if (orderId == Guid.Empty)
            throw new ArgumentException("OrderId cannot be empty.", nameof(orderId));

        OrderId = orderId;
    }
}
