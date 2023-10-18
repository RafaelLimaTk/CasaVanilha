using CasaVanilha.Application.Interfaces;
using CasaVanilha.Domain.Entities;
using System.IO.Ports;
using System.Text;

namespace CasaVanilha.Application.Services;

public class PrinterService : IPrinterService
{
    private readonly IProductService _productService;

    public PrinterService(IProductService productService)
    {
        _productService = productService;
    }

    public void PrintOrderItems(List<OrderItem> orderItems)
    {
        SerialPort sp = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
        sp.Open();

        string formattedOrderItems = FormatOrderItems(orderItems);

        sp.Write(formattedOrderItems);
        sp.Close();
    }

    private string FormatOrderItems(List<OrderItem> orderItems)
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine("Obrigado por comprar na Casa Vanilha!");
        sb.AppendLine("Nome                       Quantidade                    Valor");

        foreach (var item in orderItems)
        {
            var product = _productService.GetByIdAsync(item.ProductId);

            if (product != null)
            {
                decimal totalValue = product.Result.UnitPrice * item.Quantity;

                sb.AppendLine($"{product.Result.Name.PadRight(30)} {item.Quantity.ToString().PadRight(30)} {totalValue.ToString("F2").PadLeft(5)}");
            }
        }

        return sb.ToString();
    }
}
