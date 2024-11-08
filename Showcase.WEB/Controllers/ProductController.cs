using Microsoft.AspNetCore.Mvc;
using Showcase.Core.Entities;
using Showcase.Service.Abstract;

namespace Showcase.WEB.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new Product());
        }
        [HttpPost]
        public async Task<IActionResult> AddProduct(Product product)
        {
            await _productService.AddAsync(product);
            return RedirectToAction("Index","Home");
        }
    }
}
