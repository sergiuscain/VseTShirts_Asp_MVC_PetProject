using Microsoft.AspNetCore.Mvc;

namespace VseTShirts.Controllers
{
    public class calculator : Controller
    {
        public string index(int a, int b, char c)
        {
            if (c ==  '+')
            {
                return $"{a} + {b} =  {a + b}";
            }
            if (c == '-')
            {
                return $"{a} - {b} =  {a - b}";
            }
            if (c == '*')
            {
                return $"{a} * {b} =  {a * b}";
            }
            return "Неверное значение";
        }
    }
}
