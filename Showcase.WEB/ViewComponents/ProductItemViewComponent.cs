using Microsoft.AspNetCore.Mvc;
using Showcase.Core.Entities;

namespace Showcase.WEB.ViewComponents
{
    public class ProductItemViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(Product product)
        {
            return View(product);
        }
    }
}
