using CasaVanilha.Domain.Entities.Base;

namespace CasaVanilha.Domain.Entities;

public class Order : EntityBase
{
    private DateTime _orderDateTime;
    private string _status;
    private string _observation;
    private List<OrderItem> _orderItems = new List<OrderItem>();

    public Order() { }

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

    public string Observation
    {
        get => _observation;
        private set => SetObservation(value);
    }

    public void Close()
    {
        Status = "Fechada";
    }

    public void Open()
    {
        Status = "Nova";
    }
    public void AddOrderItem(OrderItem orderItem)
    {
        _orderItems.Add(orderItem);
    }

    public IReadOnlyCollection<OrderItem> OrderItems => _orderItems.AsReadOnly();

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

    public void SetObservation(string observation)
    {
        _observation = observation;
    }

    public void AddProduct(Product product, int quantity)
    {
        if (product == null)
            throw new ArgumentNullException(nameof(product));
        if (quantity <= 0)
            throw new ArgumentOutOfRangeException(nameof(quantity), "A quantidade deve ser maior que zero.");

        var existingOrderItem = _orderItems.SingleOrDefault(oi => oi.Product == product);
        if (existingOrderItem == null)
        {
            var newOrderItem = new OrderItem(product.Id, quantity);
            _orderItems.Add(newOrderItem);
        }
        else
        {
            existingOrderItem.AddQuantity(quantity);
        }
    }
}
