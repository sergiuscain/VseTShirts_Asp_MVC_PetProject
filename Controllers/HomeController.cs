using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VseTShirts.Models;

namespace VseTShirts.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductsStorage productStorage;
        public readonly ComparedProducts comparedProducts;

        public HomeController(IProductsStorage productStorage, ComparedProducts comparedProducts)
        {
            this.productStorage = productStorage;
            this.comparedProducts = comparedProducts;
        }


        public IActionResult Index()
        {
                return View(Mapping.ToProductsViewModel(productStorage.GetAll()));
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

        public IActionResult Compare(Guid Id)
        {
            var product1 = productStorage.GetById(Id);
            if (comparedProducts.products[0] == null)
            {
                
                comparedProducts.products[0] = Mapping.ToProductViewModel(product1);
                return RedirectToAction("Index");
            }
            else if (comparedProducts.products[1] == null)
            {
                comparedProducts.products[1] = Mapping.ToProductViewModel(product1);
                return View(comparedProducts.products);
            }
            return View(comparedProducts.products);
        }

        public IActionResult RemoveCompare()
        {
            comparedProducts.RemoveAll();
            return RedirectToAction("Index");
        }

        public IActionResult Search(string serachTxt)
        {
            var products = productStorage.GetAll();
            var newProductsList = products.Where(p => p.Name.ToLower().Contains(serachTxt.ToLower())).ToList();
            return View("Index", Mapping.ToProductsViewModel( newProductsList ));
        }
    }
}
