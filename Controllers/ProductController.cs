using Microsoft.AspNetCore.Mvc;
using VseTShirts.Models;

namespace VseTShirts.Controllers
{

    public class ProductController : Controller
    {

        public ProductController()
        {
        }
        public IActionResult Index(int id)
        {
            var product = ProductStorage.GetById(id);
            return View(product);
        }
    }
}
