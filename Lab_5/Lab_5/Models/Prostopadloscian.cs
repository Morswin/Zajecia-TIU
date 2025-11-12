using System.ComponentModel.DataAnnotations;

namespace Lab_5.Models
{
    public class Prostopadloscian
    {
        [Required(ErrorMessage = "Szerokosc trzeba podać")]
        [Range(0, double.MaxValue, ErrorMessage = "Szerokosc musi być dodatni")]
        public double Szerokosc {  get; set; }
        [Required(ErrorMessage = "Wysokosc trzeba podać")]
        [Range(0, double.MaxValue, ErrorMessage = "Wysokosc musi być dodatni")]
        public double Wysokosc { get; set; }
        [Required(ErrorMessage = "Grubosc trzeba podać")]
        [Range(0, double.MaxValue, ErrorMessage = "Grubosc musi być dodatni")]
        [RegularExpression(@"^\d*[02468]$", ErrorMessage = "Grubosc musi być parzystym integerem")]
        public double Grubosc { get; set; }
        public void Oblicz()
        {
            Objetosc = Szerokosc * Wysokosc * Grubosc;
            Pole = 2 * Szerokosc * Wysokosc + 2 * Szerokosc * Grubosc + 2 * Wysokosc * Grubosc;
        }
        public double Pole {  get; set; }
        public double Objetosc { get; set; }
    }
}
