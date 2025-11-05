using Microsoft.AspNetCore.Mvc;

namespace Lab4.Controllers
{
    public class FiguryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Oblicz(double bok)
        {
            double P = bok * bok;
            ViewBag.Pole = P;
            return View();
        }
    }
}
