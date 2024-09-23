using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VseTShirts.Models;

namespace VseTShirts.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        List<Product> products = new List<Product>()
        {
            new Product("T-Shirt1", "Description T-Shirt", 1800, 90, 1300, "/images/tshirt1.jpg", "T-Shirt"),
            new Product("T-Shirt2", "Description T-Shirt", 1800, 15, 1300, "/images/tshirt2.jpg", "T-Shirt"),
            new Product("T-Shirt3", "Description T-Shirt", 1800, 55, 1300, "/images/tshirt3.jpg", "T-Shirt"),
            new Product("T-Shirt4", "Description T-Shirt", 1800, 2, 1300, "/images/tshirt4.jpg", "T-Shirt"),
            new Product("Sweatshirt1", "Description Sweatshirt", 2500, 120, 1800, "/images/sweatshirt.jpg", "Sweatshirts"),
            new Product("Jacket1", "Description Jacket", 4000, 150, 3000, "/images/jacket.jpg","Jackets"),
            new Product("Pants1", "Description Pants", 1500, 60, 1000, "/images/pants.jpg", "Pants"),
            new Product("Shoes1", "Description Shoes", 2000, 80, 1500, "/images/shoes.jpg", "Shoes"),
            new Product("Accessories1", "Description Accessories", 500, 20, 400, "/images/accessories.jpg", "Accessories")
        };

        public HomeController(ILogger<HomeController> logger)
        {
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
        public string Product(int id)
        {
            return products[id].ToString();
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
