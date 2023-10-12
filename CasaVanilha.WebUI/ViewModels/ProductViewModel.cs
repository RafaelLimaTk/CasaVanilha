using CasaVanilha.Application.DTOs;
using X.PagedList;

namespace CasaVanilha.WebUI.ViewModels;

public class ProductViewModel
{
    public IPagedList<ProductDto> Products { get; set; }
    public string SearchTerm { get; set; }
}
