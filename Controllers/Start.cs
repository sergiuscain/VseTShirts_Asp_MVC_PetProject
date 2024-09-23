using Microsoft.AspNetCore.Mvc;

namespace VseTShirts.Controllers
{
    public class Start : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Hello()
        {
            string time = DateTime.Now.ToString("HH:mm");
            int timeH = Convert.ToInt32(time.Substring(0,2));
            int timeM = Convert.ToInt32(time.Substring(3));
            int timeInt = Convert.ToInt32(timeH + "" + timeM);
            if (timeInt >= 0 && timeInt <= 559)
            {
                return $"Good Night!\n{timeInt}";
            }
            else if (timeInt >= 600 && timeInt <= 1159)
            {
                return $"Good Morning!\n{timeInt}";
            }
            else if (timeInt >= 1200 && timeInt <= 1759)
            {
                return $"Good Afternoon!\n{timeInt}";
            }
            else if (timeInt >= 1800 && timeInt <= 2359)
            {
                return $"Good Evening!\n{timeInt}";
            }
            return $"{timeInt}";
        }
    }
}
