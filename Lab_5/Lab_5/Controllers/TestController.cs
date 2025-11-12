using Lab_5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_5.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index(Test t)
        {
            if (ModelState.IsValid)
            {
                t.Sprawdz();
                return View(t);
            }
            else
            {
                return View(new Test());
            }
        }
    }
}
