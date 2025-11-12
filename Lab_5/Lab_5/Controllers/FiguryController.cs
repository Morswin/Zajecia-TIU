using Lab_5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_5.Controllers
{
    public class FiguryController : Controller
    {
        public IActionResult Index(Kwadrat k)
        {
            if (ModelState.IsValid)
            {
                k.Oblicz();
                return View(k);
            }
            else
            {
                return View(new Kwadrat());
            }
        }
    }
}
