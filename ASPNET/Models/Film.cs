using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPNET.Models
{
    public class Film
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Nie podano tytułu")]
        public string Tytul { get; set; }
        [Required(ErrorMessage = "Nie podano reżysera")]
        public string Rezyser { get; set; }
        [StringLength(500)]
        public string Opis { get; set; }
        [Required(ErrorMessage = "Nie podano ceny")]
        public decimal Cena { get; set; }
        [Required(ErrorMessage = "Nie podano daty dodania")]
        public DateTime DataDodania { get; set; }

        public string Plakat { get; set; }        

        [ForeignKey("Kategoria")]
        public int KategoriaId { get; set; }
        public Kategoria Kategoria { get; set; }
    }
}
