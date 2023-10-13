using CasaVanilha.Application.DTOs;
using X.PagedList;

namespace CasaVanilha.WebUI.ViewModels;

public class ProductAndOrderListViewModel
{
    public IPagedList<ProductDto> PagedProductDto { get; set; }
}
