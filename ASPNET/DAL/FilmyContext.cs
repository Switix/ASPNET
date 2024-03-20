using ASPNET.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPNET.DAL
{
    public class FilmyContext : DbContext
    {

        public DbSet<Film> Filmy { get; set; }
        public DbSet<Kategoria> Kategorie { get; set; }

        public FilmyContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Film>().HasData(
            new Film()
            {
                Id = 1,
                Cena = 12.36M,
                DataDodania = DateTime.Now,
                Opis = "Bardzo ciekawy i interesujacy film",
                Tytul = "Ready Palyer One",
                Rezyser = "Adam Małysz",
                KategoriaId = 1
            },
            new Film()
            {
                Id = 2,
                Cena = 24.94M,
                DataDodania = new DateTime(2024, 3, 6),
                Opis = "Film oparty na faktach",
                Tytul = "Sen na javie",
                Rezyser = "Miłosz Jacoszek",
                KategoriaId = 2
            },
            new Film()
            {
                Id = 3,
                Cena = 29.99M,
                DataDodania = new DateTime(2023, 12, 16),
                Opis = "Film Dokumentalny",
                Tytul = "Szybcy i wściekli 21",
                Rezyser = "Paweł Marciniak",
                KategoriaId = 3
            },
            new Film()
            {
                Id = 4,
                Cena = 15.68M,
                DataDodania = new DateTime(2024, 11, 23),
                Opis = "Bardzo ciekawy i interesujacy film",
                Tytul = "Ready Palyer One",
                Rezyser = "Adam Małysz",
                KategoriaId = 1
            },
            new Film()
            {
                Id = 5,
                Cena = 50.17M,
                DataDodania = new DateTime(2023, 1, 3),
                Opis = "Film oparty na faktach",
                Tytul = "Sen na javie",
                Rezyser = "Miłosz Jacoszek",
                KategoriaId = 2
            },
            new Film()
            {
                Id = 6,
                Cena = 19.99M,
                DataDodania = new DateTime(2023, 1, 5),
                Opis = "Film Dokumentalny",
                Tytul = "Szybcy i wściekli 21",
                Rezyser = "Paweł Marciniak",
                KategoriaId = 3
            },
            new Film()
            {
                Id = 7,
                Cena = 10.99M,
                DataDodania = new DateTime(2023, 2, 13),
                Opis = "Bardzo ciekawy i interesujacy film",
                Tytul = "Ready Palyer One",
                Rezyser = "Adam Małysz",
                KategoriaId = 1
            },
            new Film()
            {
                Id = 8,
                Cena = 36.444M,
                DataDodania = new DateTime(2024, 2, 13),
                Opis = "Film oparty na faktach",
                Tytul = "Sen na javie",
                Rezyser = "Miłosz Jacoszek",
                KategoriaId = 2
            },
            new Film()
            {
                Id = 9,
                Cena = 31.11M,
                DataDodania = new DateTime(2024, 2, 17),
                Opis = "Film Dokumentalny",
                Tytul = "Szybcy i wściekli 21",
                Rezyser = "Paweł Marciniak",
                KategoriaId = 3
            },
            new Film()
            {
                Id = 10,
                Cena = 12.47M,
                DataDodania = new DateTime(2024, 4, 23),
                Opis = "Bardzo ciekawy i interesujacy film",
                Tytul = "Ready Palyer One",
                Rezyser = "Adam Małysz",
                KategoriaId = 1
            }
            );

            modelBuilder.Entity<Kategoria>().HasData(
                new Kategoria() { Id = 1, Nazwa = "Sci=Fi", Opis = "Filmy typu Sci-Fi" },
                new Kategoria() { Id = 2, Nazwa = "fakty", Opis = "Filmy oparte na faktach" },
                new Kategoria() { Id = 3, Nazwa = "Akcji", Opis = "Filmy pełne wybuchów" }
           );
        }
    }
}
