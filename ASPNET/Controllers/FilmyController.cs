using ASPNET.DAL;
using ASPNET.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPNET.Controllers
{
    public class FilmyController : Controller
    {
        FilmyContext db;
        IWebHostEnvironment hostEnviroment;

        public FilmyController(FilmyContext db, IWebHostEnvironment hostEnviroment)
        {
            this.db = db;
            this.hostEnviroment = hostEnviroment;
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
       
            var film = db.Filmy.Include("Kategoria")
                .First(f => f.Id == idFilmu);
            
            return View(film);
        }
        [HttpGet]
        public IActionResult DodajFilm()
        {
            DodawanieFilmu dodaj = new DodawanieFilmu();

            var kategorie = db.Kategorie.ToList();

            dodaj.Kategorie = kategorie;

            return View(dodaj);
        }

        [HttpPost]
        public IActionResult DodajFilm(DodawanieFilmu obj)
        {
            obj.Film.DataDodania = DateTime.Now;
            
            var sciezkaPlakatu = Path.Combine(hostEnviroment.WebRootPath, "Content");
            var nazwaPlakatuUnikat = Guid.NewGuid()+"_"+obj.Plakat.FileName;       
            var sciezkaDoPlakatu = Path.Combine(sciezkaPlakatu, nazwaPlakatuUnikat);
            obj.Plakat.CopyTo(new FileStream(sciezkaDoPlakatu, FileMode.Create));
            obj.Film.Plakat = nazwaPlakatuUnikat;
            
            var kategoria = db.Kategorie.Find(obj.Film.KategoriaId);
            obj.Film.Kategoria = kategoria;

            db.Add(obj.Film);
            db.SaveChanges();   

            return RedirectToAction("Szczegoly",new {idFilmu = obj.Film.Id});
        }
    }
}
