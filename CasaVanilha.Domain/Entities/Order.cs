using CasaVanilha.Domain.Entities.Base;

namespace CasaVanilha.Domain.Entities;

public class Order : EntityBase
{
    private DateTime _orderDateTime;
    private string _status;
    private readonly List<OrderItem> _orderItems = new List<OrderItem>();

    private Order() { }

    public Order(DateTime orderDateTime, string status)
    {
        SetOrderDateTime(orderDateTime);
        SetStatus(status);
    }

    public DateTime OrderDateTime
    {
        get => _orderDateTime;
        private set => SetOrderDateTime(value);
    }

    public string Status
    {
        get => _status;
        private set => SetStatus(value);
    }

    public IReadOnlyCollection<OrderItem> OrderItems => _orderItems.AsReadOnly();

    public void RemoveOrderItem(OrderItem orderItem)
    {
        _orderItems.Remove(orderItem);
    }

    private void SetOrderDateTime(DateTime orderDateTime)
    {
        if (orderDateTime == default)
            throw new ArgumentException("Order date time cannot be default", nameof(orderDateTime));
        _orderDateTime = orderDateTime;
    }

    private void SetStatus(string status)
    {
        if (string.IsNullOrWhiteSpace(status))
            throw new ArgumentException("Status cannot be empty or null", nameof(status));
        _status = status;
    }

    public void AddOrderItem(OrderItem orderItem)
    {
        if (orderItem == null)
            throw new ArgumentNullException(nameof(orderItem));
        _orderItems.Add(orderItem);
    }
}
