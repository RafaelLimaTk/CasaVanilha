using CasaVanilha.Domain.Entities.Base;
using CasaVanilha.Domain.ExtensionMethods;

namespace CasaVanilha.Domain.Entities;

public class OrderItem : EntityBase
{
    private int _quantity;
    private decimal _unitPrice;
    private Product _product;

    private OrderItem() { }

    public OrderItem(Product product, int quantity, decimal unitPrice)
    {
        SetProduct(product);
        SetQuantity(quantity);
        SetUnitPrice(unitPrice);
    }

    public Product Product
    {
        get => _product;
        private set => SetProduct(value);
    }

    public int Quantity
    {
        get => _quantity;
        private set => SetQuantity(value);
    }

    public decimal UnitPrice
    {
        get => _unitPrice;
        private set => SetUnitPrice(value);
    }

    private void SetProduct(Product product)
    {
        _product = product ?? throw new ArgumentNullException(nameof(product));
    }

    private void SetQuantity(int quantity)
    {
        quantity.EnsureGreaterThanZero(nameof(quantity));
        _quantity = quantity;
    }

    private void SetUnitPrice(decimal unitPrice)
    {
        unitPrice.EnsureGreaterThanZero(nameof(unitPrice));
        _unitPrice = unitPrice;
    }
}
