using ASPNET.DAL;
using ASPNET.helpers;
using ASPNET.Models;
using Microsoft.AspNetCore.Http;
using System.Linq;

namespace ASPNET.Infrastructure
{
    public static class MenadzerKoszyka
    {
        public static int UsunZkoszyka(ISession session, int id)
        {
            var koszyk = PobierzKoszyk(session);
            var film = koszyk.Find(i=> i.Film.Id == id);

            int ilosc = 0;
            if(film == null)
            {
                return ilosc;
            }
            if(film.Ilosc > 1)
            {
                film.Ilosc--;
                ilosc = film.Ilosc;
            }
            else
            {
                koszyk.Remove(film);
            }

            SessionHelper.SetObjectAsJson(session, Consts.KoszykSesja, koszyk);
            return ilosc;
        }

        private static List<ElementKoszyka> PobierzKoszyk(ISession session)
        {
            var koszyk = SessionHelper.GetObjectFromJson<List<ElementKoszyka>>(session, Consts.KoszykSesja);
            koszyk ??= new List<ElementKoszyka>();
            return koszyk;
        }

        public static void DodajDoKoszyka(ISession session, FilmyContext db, int filmId)
        {
            var koszyk = PobierzKoszyk(session);
             var szukanyFilm = koszyk.Find(i=>i.Film.Id == filmId);

            if(szukanyFilm != null)
            {
                szukanyFilm.Ilosc++;
            }
            else
            {
                var filmZbazy = db.Filmy.Where(f=>f.Id == filmId).FirstOrDefault();
                if(filmZbazy != null)
                {
                    var elementKoszyka = new ElementKoszyka
                    {
                        Film = filmZbazy,
                        Ilosc = 1,
                        Wartosc = filmZbazy.Cena
                    };
                    koszyk.Add(elementKoszyka);
                }
            }
            SessionHelper.SetObjectAsJson(session, Consts.KoszykSesja, koszyk);
        }
        public static int IlosElemKoszyka(ISession session)
        {
            var koszyk = PobierzKoszyk(session);

            return koszyk.Sum(f => f.Ilosc);
        }
    }
}
