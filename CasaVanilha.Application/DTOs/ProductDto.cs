using System.ComponentModel.DataAnnotations;

namespace CasaVanilha.Application.DTOs;

public class ProductDto
{
    public Guid Id { get; set; }

    [Required(ErrorMessage = "O nome do produto é obrigatório.")]
    [StringLength(120, ErrorMessage = "O nome do produto não pode exceder 120 caracteres.")]
    public string? Name { get; set; }

    [StringLength(500, ErrorMessage = "A descrição do produto não pode exceder 500 caracteres.")]
    public string? Description { get; set; }

    [Required(ErrorMessage = "O preço unitário é obrigatório.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "O preço unitário deve ser maior que zero.")]
    public decimal UnitPrice { get; set; }

    [Required(ErrorMessage = "A quantidade em estoque é obrigatória.")]
    [Range(0, int.MaxValue, ErrorMessage = "A quantidade em estoque não pode ser negativa.")]
    public int StockQuantity { get; set; }
}
