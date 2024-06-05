using ASPNET.DAL;
using ASPNET.helpers;
using ASPNET.Infrastructure;
using ASPNET.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

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

            if (koszyk != null)
            {
                ViewBag.CalaSuma = koszyk.Sum(f => f.Film.Cena * f.Ilosc); 
                ViewBag.SumaElementow = MenadzerKoszyka.IlosElemKoszyka(HttpContext.Session);
            }
            else
            {
                ViewBag.SumaElementow = 0;
                ViewBag.CalaSuma = 0; 
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

        public IActionResult UsunZKoszyka(int id)
        {
            List<ElementKoszyka> koszyk = SessionHelper.GetObjectFromJson<List<ElementKoszyka>>(HttpContext.Session, Consts.KoszykSesja);

            int index = koszyk.FindIndex(i => i.Film.Id == id); 
            koszyk.RemoveAt(index);

            SessionHelper.SetObjectAsJson(HttpContext.Session, Consts.KoszykSesja, koszyk);
            return RedirectToAction("Index");

        }

        public IActionResult UsunZkoszykaJson(int id)
        {
            var model = new UsunModelKoszyk()
            {
                Id = id,
                Ilosc = MenadzerKoszyka.UsunZkoszyka(HttpContext.Session, id),
                WartoscKoszyka = MenadzerKoszyka.IlosElemKoszyka(HttpContext.Session)
            };
            return View(model);
            
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            ViewBag.SumaElementow = MenadzerKoszyka.IlosElemKoszyka(HttpContext.Session);


            return await Task.FromResult((IViewComponentResult)View("_Menu", db.Kategorie.ToList()));
        }
    }
}
