using AutoMapper;
using X.PagedList;
using CasaVanilha.Application.DTOs;
using CasaVanilha.Application.Interfaces;
using CasaVanilha.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using CasaVanilha.WebUI.ViewModels;
using CasaVanilha.Application.Services;
using CasaVanilha.Domain.Entities;

namespace CasaVanilha.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;
        private readonly IOrderService _orderService;
        private readonly IOrderItemService _orderItemService;
        private readonly IMapper _mapper;

        public HomeController(ILogger<HomeController> logger, IProductService productService, IMapper mapper,
            IOrderService orderService, IOrderItemService orderItemService)
        {
            _logger = logger;
            _productService = productService;
            _mapper = mapper;
            _orderService = orderService;
            _orderItemService = orderItemService;
        }

        public async Task<IActionResult> Index(Guid? orderId, int? productPage, int? orderPage)
        {
            Guid orderIdValue;
            if (HttpContext.Request.Cookies.ContainsKey("OrderId"))
            {
                HttpContext.Response.Cookies.Delete("OrderId");
            }

            var newOrder = await _orderService.GetOpenOrderAsync();
            if (newOrder != null)
            {
                var isOrderEmpty = _orderItemService.GetProductsByOrderId(newOrder.Id);
                if (!isOrderEmpty.Any())
                {
                    await _orderService.DeleteAsync(newOrder.Id);
                }
            }

            orderIdValue = await _orderService.CreateOrderAsync();
            HttpContext.Response.Cookies.Append("OrderId", orderIdValue.ToString());

            var products = await _productService.GetAllAsync();

            var allProductDtos = _mapper.Map<IEnumerable<ProductDto>>(products);

            int pageSize = 15;
            int productPageNumber = (productPage ?? 1);
            int orderPageNumber = (orderPage ?? 1);

            var productAndOrderListViewModel = new ProductAndOrderListViewModel
            {
                PagedProductDto = allProductDtos.ToPagedList(productPageNumber, pageSize),
            };

            return View(productAndOrderListViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> GetOrderItems(Guid orderId)
        {
            var orderItems = _orderItemService.GetProductsByOrderId(orderId);
            var productOrderItemDtos = _mapper.Map<IEnumerable<OrderItemDto>>(orderItems);
            return Json(productOrderItemDtos);
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