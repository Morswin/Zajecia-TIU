using Microsoft.AspNetCore.Mvc;

namespace Lab4.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sprawdz(string pyt1,
            string pyt2,
            string pyt3,
            string pyt4,
            string pyt5,
            string[] pyt6,
            string[] pyt7_1, 
            string[] pyt7_2, 
            string[] pyt7_3, 
            string[] pyt7_4,
            string[] pyt8
            )
        {
            int punkty = 0;

            if (pyt1?.Trim().ToLower() == "docker pull node:latest") punkty++;
            if (pyt2?.Trim().ToLower() == "docker images") punkty++;
            if (pyt3 == "Tak") punkty++;
            if (pyt4 == "kroki") punkty++;
            if (pyt5 == "Nie") punkty++;

            if (pyt6 != null && pyt6.Contains("build") && pyt6.Contains("rmi") && pyt6.Length == 2)
                punkty++;

            if (pyt7_1 != null && pyt7_1.Contains("uruchomic") && pyt7_3.Contains("okreslic") && pyt7_2.Length == 0 && pyt7_4.Length == 0)
                punkty++;

            if (pyt8 != null && pyt8.Contains("latwiejsze") && pyt8.Contains("spojne") && pyt8.Length == 2)
                punkty++;

            ViewBag.punkty = punkty;
            return View();
        }
    }
}
