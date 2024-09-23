using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VseTShirts.Models;

namespace VseTShirts.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public string Index()
        {
            List<Products> products = new List<Products>();
            products.Add(new Products { Id = 1, Name = "Shirt 1", Price = 25 });
            products.Add(new Products { Id = 2, Name = "Shirt 2", Price = 30 });
            products.Add(new Products { Id = 3, Name = "Shirt 3", Price = 35 });
            string result = "";
            foreach (var product in products)
            {
                result += $"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}\n";
            }
            return result;
        }

        public IActionResult Privacy(string a)
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
