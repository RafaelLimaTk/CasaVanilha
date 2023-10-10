using AutoMapper;
using CasaVanilha.Application.DTOs;
using CasaVanilha.Application.Interfaces;
using CasaVanilha.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

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

        public async Task<IActionResult>Index()
        {
            var Product = await _productService.GetAllAsync();
            var ProductDto = _mapper.Map<IEnumerable<ProductDto>>(Product);

            return View(ProductDto);
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