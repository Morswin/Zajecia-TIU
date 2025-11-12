using System.ComponentModel.DataAnnotations;

namespace Lab_5.Models
{
    public class Kwadrat
    {
        [Required(ErrorMessage ="Bok trzeba podać")]
        [Range(0, double.MaxValue, ErrorMessage ="Bok musi być dodatni")]
        [RegularExpression(@"$\d{3,}^")]
        public double Bok { get; set; }
        public void Oblicz()
        {
            Pole = Bok * Bok;
        }
        public double Pole { get; set; }
    }
}
