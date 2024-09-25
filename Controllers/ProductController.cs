using Microsoft.AspNetCore.Mvc;
using VseTShirts.Models;

namespace VseTShirts.Controllers
{

    public class ProductController : Controller
    {
        private ProductStorage storage;

        public ProductController()
        {
            storage = new ProductStorage();
        }
        public IActionResult Index(int id)
        {
            var product = storage.GetById(id);
            return View(product);
        }
    }
}
