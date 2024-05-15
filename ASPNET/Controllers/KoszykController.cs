using ASPNET.DAL;
using ASPNET.helpers;
using ASPNET.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNET.Controllers
{
    public class KoszykController:Controller
    {
        FilmyContext db;

        public KoszykController(FilmyContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var koszyk = SessionHelper.GetObjectFromJson<List<ElementKoszyka>>(HttpContext.Session, Consts.KoszykSesja);

            // Check if koszyk is not null
            if (koszyk != null)
            {
                ViewBag.CalaSuma = koszyk.Sum(f => f.Film.Cena * f.Ilosc);
            }
            else
            {
                // If koszyk is null, set ViewBag.CalaSuma to 0 or any other default value
                ViewBag.CalaSuma = 0; // or any other default value
            }

            return View(koszyk);
        }

        public IActionResult Kup(int id)
        {
            var film = db.Filmy.Where(f => f.Id == id).Single();

            if(SessionHelper.GetObjectFromJson<List<ElementKoszyka>>(HttpContext.Session, Consts.KoszykSesja) == null)
            {
                List<ElementKoszyka> koszyk = new() { 
                    new ElementKoszyka 
                    {
                        Film = film,
                        Ilosc=1,
                        Wartosc=film.Cena
                    }
                };
                SessionHelper.SetObjectAsJson(HttpContext.Session, Consts.KoszykSesja, koszyk);
            }
            else
            {
                List<ElementKoszyka> koszyk = SessionHelper.GetObjectFromJson<List<ElementKoszyka>>(HttpContext.Session, Consts.KoszykSesja);

                var index = koszyk.FindIndex(i => i.Film.Id == id);
                if(index != -1)
                {
                    koszyk[index].Ilosc++;
                }
                else
                {
                    koszyk.Add(new ElementKoszyka
                    {
                        Film = film,
                        Ilosc = 1,
                        Wartosc = film.Cena
                    });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, Consts.KoszykSesja, koszyk);
            }
            return RedirectToAction("Index");
        }
    }
}
