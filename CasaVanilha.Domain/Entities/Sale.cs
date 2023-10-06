using CasaVanilha.Domain.Entities.Base;
using CasaVanilha.Domain.ExtensionMethods;

namespace CasaVanilha.Domain.Entities;

public class Sale : EntityBase
{
    private DateTime _saleDateTime;
    private int _quantitySold;
    private Product _product;

    private Sale() { } 

    public Sale(Product product, int quantitySold, DateTime saleDateTime)
    {
        SetProduct(product);
        SetQuantitySold(quantitySold);
        SetSaleDateTime(saleDateTime);
    }

    public Product Product
    {
        get => _product;
        private set => SetProduct(value);
    }

    public int QuantitySold
    {
        get => _quantitySold;
        private set => SetQuantitySold(value);
    }

    public DateTime SaleDateTime
    {
        get => _saleDateTime;
        private set => SetSaleDateTime(value);
    }

    private void SetProduct(Product product)
    {
        _product = product ?? throw new ArgumentNullException(nameof(product));
    }

    private void SetQuantitySold(int quantitySold)
    {
        quantitySold.EnsureGreaterThanZero(nameof(quantitySold));
        _quantitySold = quantitySold;
    }

    private void SetSaleDateTime(DateTime saleDateTime)
    {
        saleDateTime.EnsureNotDefault(nameof(saleDateTime));
        _saleDateTime = saleDateTime;
    }
}
