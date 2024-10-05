using Microsoft.AspNetCore.Mvc;
using VseTShirts.Models;

namespace VseTShirts.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IRolesStorage rolesStorage;
        public UserController(IRolesStorage rolesStorage)
        {
            this.rolesStorage = rolesStorage;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
