using AutoMapper;
using X.PagedList;
using CasaVanilha.Application.DTOs;
using CasaVanilha.Application.Interfaces;
using CasaVanilha.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using CasaVanilha.WebUI.ViewModels;

namespace CasaVanilha.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public HomeController(ILogger<HomeController> logger, IProductService productService, IMapper mapper)
        {
            _logger = logger;
            _productService = productService;
            _mapper = mapper;
        }

        public async Task<IActionResult>Index(int? page)
        {
            var Product = await _productService.GetAllAsync();
            var ProductDto = _mapper.Map<IEnumerable<ProductDto>>(Product);

            int pageSize = 15;
            int pageNumber = (page ?? 1);

            var pagedProductDto = ProductDto.ToPagedList(pageNumber, pageSize);

            return View(pagedProductDto);
        }

        [HttpGet]
        public async Task<JsonResult> AjaxIndex(int? page, string searchTerm = null)
        {
            var Product = await _productService.GetAllAsync();

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                Product = Product.Where(p => p.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase));
            }

            var ProductDto = _mapper.Map<IEnumerable<ProductDto>>(Product);

            int pageSize = 15;
            int pageNumber = (page ?? 1);

            var pagedProductDto = ProductDto.ToPagedList(pageNumber, pageSize);

            return Json(new { Products = pagedProductDto, SearchTerm = searchTerm });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}