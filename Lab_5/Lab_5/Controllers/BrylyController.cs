using Lab_5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_5.Controllers
{
    public class BrylyController : Controller
    {
        public IActionResult Index(Prostopadloscian p)
        {
            if (ModelState.IsValid)
            {
                p.Oblicz();
                return View(p);
            }
            else
            {
                return View(new Prostopadloscian());
            }
        }
    }
}
