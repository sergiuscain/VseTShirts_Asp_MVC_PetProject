using Microsoft.AspNetCore.Mvc;
using VseTShirts.Models;

namespace VseTShirts.Controllers
{

    public class ProductController : Controller
    {
        private readonly ProductsInMemoryStorage productStorage;
        public ProductController(ProductsInMemoryStorage productsStorage)
        {
            this.productStorage = productsStorage;
        }
        public IActionResult Index(int id)
        {
            var product = productStorage.GetById(id);
            return View(product);
        }
    }
}
