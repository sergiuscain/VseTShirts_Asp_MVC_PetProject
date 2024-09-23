using Microsoft.AspNetCore.Mvc;

namespace VseTShirts.Controllers
{
    public class calculator : Controller
    {
        public string plus(int a, int b)
        {

            return $"{a} + {b} =  {a+b}";
        }
    }
}
