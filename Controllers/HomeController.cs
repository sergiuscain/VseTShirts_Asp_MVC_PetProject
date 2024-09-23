using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VseTShirts.Models;

namespace VseTShirts.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private List<Product> products;
        ProductStorage productsStorage = new ProductStorage();

        public HomeController(ILogger<HomeController> logger)
        {
            products = productsStorage.GetAll();
            _logger = logger;
        }

        public string Index()
        {
            string result = "";
            foreach (var item in products)
            {
                result += $"{item.ToString()}\n";
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
