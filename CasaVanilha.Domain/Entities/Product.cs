using CasaVanilha.Domain.Entities.Base;
using CasaVanilha.Domain.ExtensionMethods;

namespace CasaVanilha.Domain.Entities;

public class Product : EntityBase
{
    private string _name;
    private string _description;
    private decimal _unitPrice;
    private int _stockQuantity;
    private readonly List<OrderItem> _orderItems = new List<OrderItem>();

    private Product() { }

    public Product(string name, string description, decimal unitPrice, int stockQuantity)
    {
        SetName(name);
        SetDescription(description);
        SetUnitPrice(unitPrice);
        SetStockQuantity(stockQuantity);
    }

    public string Name
    {
        get => _name;
        private set => SetName(value);
    }

    public string Description
    {
        get => _description;
        private set => SetDescription(value);
    }

    public decimal UnitPrice
    {
        get => _unitPrice;
        private set => SetUnitPrice(value);
    }

    public int StockQuantity
    {
        get => _stockQuantity;
        private set => SetStockQuantity(value);
    }

    private void SetName(string name)
    {
        name.EnsureNotNullOrEmpty(nameof(name));
        _name = name;
    }

    private void SetDescription(string description)
    {
        _description = description ?? throw new ArgumentNullException(nameof(description));
    }

    private void SetUnitPrice(decimal unitPrice)
    {
        unitPrice.EnsureGreaterThanZero(nameof(unitPrice));
        _unitPrice = unitPrice;
    }

    private void SetStockQuantity(int stockQuantity)
    {
        if (stockQuantity < 0)
            throw new ArgumentOutOfRangeException(nameof(stockQuantity), "Stock quantity cannot be negative");
        _stockQuantity = stockQuantity;
    }

    public IReadOnlyCollection<OrderItem> OrderItems => _orderItems.AsReadOnly();
    public void AddOrderItem(OrderItem orderItem)
    {
        if (orderItem == null)
            throw new ArgumentNullException(nameof(orderItem));

        _orderItems.Add(orderItem);
    }

    public void RemoveOrderItem(OrderItem orderItem)
    {
        if (orderItem == null)
            throw new ArgumentNullException(nameof(orderItem));

        _orderItems.Remove(orderItem);
    }
}
