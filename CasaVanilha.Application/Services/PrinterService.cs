using CasaVanilha.Application.Interfaces;
using CasaVanilha.Domain.Entities;
using System.Drawing;
using System.Drawing.Printing;
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
        PrintDocument printDoc = new PrintDocument();
        printDoc.PrinterSettings.PrinterName = "POS58";

        printDoc.PrintPage += (sender, e) =>
        {
            string formattedOrderItems = FormatOrderItems(orderItems);
            Font printFont = new Font("Arial", 6);
            e.Graphics.DrawString(formattedOrderItems, printFont, Brushes.Black, 10, 10);
        };

        try
        {
            printDoc.Print();
            Console.WriteLine("Sucesso ao imprimir.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao tentar imprimir: {ex.Message}");
        }
    }

    private string FormatOrderItems(List<OrderItem> orderItems)
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine("               Casa Vanillah            ");
        sb.AppendLine("-----------------");

        sb.AppendLine("-----------------");
        sb.AppendLine("QTD     Descrição                             Valor");

        decimal totalValueProduct = 0m;
        foreach (var item in orderItems)
        {
            var product = _productService.GetByIdAsync(item.ProductId);

            if (product != null)
            {
                decimal totalValue = product.Result.UnitPrice * item.Quantity;
                totalValueProduct += totalValue;

                sb.AppendLine($"{item.Quantity.ToString().PadRight(6)} {product.Result.Name.PadRight(35)} {totalValue.ToString("F2").PadLeft(5)}");
            }
        }
        sb.AppendLine("------------------------------------------");
        sb.AppendLine($"Total {totalValueProduct.ToString("F2")}");

        return sb.ToString();
    }
}
