using Microsoft.AspNetCore.Mvc;
using VseTShirts.Models;

namespace VseTShirts.Controllers
{
    public class AccauntController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login( LoginModel login)
        {
                return RedirectToAction("Index", "Home");
        }

        public IActionResult Logout()
        {
            return View();
        }

        public IActionResult Register(RegisterModel register)
        {
            return View();
        }

        public IActionResult ResetPassword()
        {
            return View();
        }

    }
}
