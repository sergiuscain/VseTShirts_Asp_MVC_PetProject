using Microsoft.AspNetCore.Mvc;

namespace VseTShirts.Controllers
{
    public class AdminController : Controller
    {
        private readonly IProductsStorage productsStorage;
        public AdminController(IProductsStorage productsStorage)
        {
            this.productsStorage = productsStorage;
        }
        public IActionResult Orders()
        {
            return View();
        }

        public IActionResult Products()
        {
            var products = productsStorage.GetAll();
            return View(products);
        }

        public IActionResult Users()
        {
            return View();
        }

        public IActionResult Roles()
        {
            return View();
        }
    }
}
