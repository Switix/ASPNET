using System.ComponentModel.DataAnnotations;

namespace ASPNET.Models
{
    public class Kategoria
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nie podano nazwy")]
        public string Nazwa { get; set; }
        [StringLength(500)]
        public string Opis { get; set; }

        public ICollection<Film> Filmy { get; set; }
    }
}
