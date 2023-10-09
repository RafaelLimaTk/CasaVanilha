using System.ComponentModel.DataAnnotations;

namespace CasaVanilha.Application.DTOs;

public class SaleDto
{
    public Guid Id { get; set; }

    [Required(ErrorMessage = "A quantidade vendida é obrigatória.")]
    [Range(1, int.MaxValue, ErrorMessage = "A quantidade vendida deve ser maior que zero.")]
    public int QuantitySold { get; set; }

    [Required(ErrorMessage = "A data e hora de venda são obrigatórias.")]
    public DateTime SaleDateTime { get; set; }

    public Guid ProductId { get; set; }
    public ProductDto Product { get; set; }
}
