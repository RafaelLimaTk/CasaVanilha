using CasaVanilha.Application.DTOs;
using CasaVanilha.Application.Interfaces;
using CasaVanilha.WebUI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CasaVanilha.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> Modal_Create()
        {
            var ProductCreateModel = new ProductEditViewModel
            {
                Product = new ProductDto(),
            };

            return PartialView(ProductCreateModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductEditViewModel productEditViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _productService.CreateAsync(productEditViewModel.Product);

            return Json(true);
        }
    }
}
