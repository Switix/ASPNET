using ASPNET.DAL;
using ASPNET.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPNET.Controllers
{
    public class FilmyController : Controller
    {
        FilmyContext db;

        public FilmyController(FilmyContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StronyStatyczne(string nazwa)
        {
            return View(nazwa);
        }

        public IActionResult Lista(string nazwaKategorii)
        {
            var kategorie = db.Kategorie
                .Include("Filmy")
                .Where(kategoria=> kategoria.Nazwa.ToUpper() == nazwaKategorii.ToUpper())
                .Single();
            var filmy = kategorie.Filmy.ToList();
            return View(filmy);
        }
        public IActionResult Szczegoly(int idFilmu)
        {
            var film = db.Filmy.Find(idFilmu);
            
            return View(film);
        }

        public IActionResult DodajFilm()
        {
            DodawanieFilmu dodaj = new DodawanieFilmu();

            var kategorie = db.Kategorie.ToList();

            dodaj.Kategorie = kategorie;

            return View(dodaj);
        }

        public IActionResult DodajFilm(DodawanieFilmu obj)
        {
            obj.Film.DataDodania = DateTime.Now;

            db.Add(obj.Film);
            db.SaveChanges();   

            return RedirectToAction("DodajFilm");
        }
    }
}
