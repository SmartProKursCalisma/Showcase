using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Showcase.Service.Abstract;

namespace Showcase.WEB.ViewComponents
{
    public class ProductListViewComponent : ViewComponent
    {
        private readonly IProductService _productService;

        public ProductListViewComponent(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var result = await _productService.GetQueryable(x => x.IsActive).ToListAsync();
            return View(result);
        }
    }
}
