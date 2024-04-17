using ASPNET.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPNET.ViewComponents
{
    public class FilmyKategorieViewComponent : ViewComponent
    {
        FilmyContext db;

        public FilmyKategorieViewComponent(FilmyContext db)
        {
            this.db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync(string nazwaKateggorii)
        {
            var model = db.Kategorie.Include("Filmy")
                .Where(Kategoria => Kategoria.Nazwa.ToUpper() == nazwaKateggorii.ToUpper()).Single().Filmy.ToList();
            return await Task.FromResult((IViewComponentResult)View("_FilmyKategorii", model));
        }
    }
}

