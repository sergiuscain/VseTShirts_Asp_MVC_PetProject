using Microsoft.AspNetCore.Mvc;

namespace VseTShirts.Controllers
{
    public class calculator : Controller
    {
        public string index(float a, float b, char c)
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
            if (c == '/')
            {
                if (b == 0)
                    return "На ноль делить нельзя";
                else
                    return $"{a} / {b} = {a/b}";
            }
            return "Неверное значение";
        }
    }
}
