using Microsoft.AspNetCore.Mvc;

namespace VseTShirts.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
