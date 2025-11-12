using System.ComponentModel.DataAnnotations;

namespace Lab_5.Models
{
    public class Test
    {
        public string? pyt1 { get; set; }
        public string? pyt2 { get; set; }
        public string? pyt3 { get; set; }
        public string? pyt4 { get; set; }
        public string? pyt5 { get; set; }
        public string[]? pyt6 { get; set; }
        public bool pyt7_1 { get; set; }
        public bool pyt7_2 { get; set; }
        public bool pyt7_3 { get; set; }
        public bool pyt7_4 { get; set; }
        public string[]? pyt8 { get; set; }
        public void Sprawdz()
        {
            if (pyt1?.Trim().ToLower() == "docker pull node:latest") punkty++;
            if (pyt2?.Trim().ToLower() == "docker images") punkty++;
            if (pyt3 == "Tak") punkty++;
            if (pyt4 == "kroki") punkty++;
            if (pyt5 == "Nie") punkty++;

            if (pyt6 != null && pyt6.Contains("build") && pyt6.Contains("rmi") && pyt6.Length == 2)
                punkty++;

            if (pyt7_1 && pyt7_3 && !pyt7_2 && !pyt7_4)
                punkty++;

            if (pyt8 != null && pyt8.Contains("latwiejsze") && pyt8.Contains("spojne") && pyt8.Length == 2)
                punkty++;
        }
        public int punkty { get; set; }
    }
}
