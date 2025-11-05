using Microsoft.AspNetCore.Mvc;

namespace Lab4.Controllers
{
    public class BrylyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Oblicz(double wysokosc, double promien, String figura, String[] obliczenia)
        {
            double P = 0, V = 0, l = 0;
            switch (figura)
            {
                case "walec":
                    P = 2 * Math.PI * promien * promien + 2 * Math.PI * promien * wysokosc;
                    V = Math.PI * promien * promien * wysokosc;
                    break;
                case "stozek":
                    l = Math.Sqrt(promien * promien + wysokosc * wysokosc);
                    P = Math.PI * promien * (promien + l);
                    V = (1.0 / 3.0) * Math.PI * promien * promien * wysokosc;
                    break;
                case "stozek2":
                    l = Math.Sqrt(promien * promien + wysokosc * wysokosc);
                    P = 2 * Math.PI * promien * (promien + l);
                    V = 2 * (1.0 / 3.0) * Math.PI * promien * promien * wysokosc;
                    break;
            }
            if (obliczenia.Contains("pole"))
                ViewBag.Pole = P;
            if (obliczenia.Contains("objetosc"))
                ViewBag.Objetosc = V;
            return View();
        }
    }
}
