﻿// <auto-generated />
using System;
using ASPNET.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASPNET.Migrations
{
    [DbContext(typeof(FilmyContext))]
    [Migration("20240417081510_FilmImage")]
    partial class FilmImage
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ASPNET.Models.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Cena")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DataDodania")
                        .HasColumnType("datetime2");

                    b.Property<int>("KategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Plakat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rezyser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tytul")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KategoriaId");

                    b.ToTable("Filmy");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cena = 12.36m,
                            DataDodania = new DateTime(2024, 4, 17, 10, 15, 10, 477, DateTimeKind.Local).AddTicks(7328),
                            KategoriaId = 1,
                            Opis = "Bardzo ciekawy i interesujacy film",
                            Plakat = "Content/readyPlayerOne.jpg",
                            Rezyser = "Adam Małysz",
                            Tytul = "Ready Palyer One"
                        },
                        new
                        {
                            Id = 2,
                            Cena = 24.94m,
                            DataDodania = new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KategoriaId = 2,
                            Opis = "Film oparty na faktach",
                            Plakat = "Content/senNaJavie.jpg",
                            Rezyser = "Miłosz Jacoszek",
                            Tytul = "Sen na javie"
                        },
                        new
                        {
                            Id = 3,
                            Cena = 29.99m,
                            DataDodania = new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KategoriaId = 3,
                            Opis = "Film Dokumentalny",
                            Plakat = "Content/szybcyIWsciekli.jpg",
                            Rezyser = "Paweł Marciniak",
                            Tytul = "Szybcy i wściekli 21"
                        },
                        new
                        {
                            Id = 4,
                            Cena = 15.68m,
                            DataDodania = new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KategoriaId = 1,
                            Opis = "Bardzo ciekawy i interesujacy film",
                            Plakat = "Content/readyPlayerOne.jpg",
                            Rezyser = "Adam Małysz",
                            Tytul = "Ready Palyer One"
                        },
                        new
                        {
                            Id = 5,
                            Cena = 50.17m,
                            DataDodania = new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KategoriaId = 2,
                            Opis = "Film oparty na faktach",
                            Plakat = "Content/senNaJavie.jpg",
                            Rezyser = "Miłosz Jacoszek",
                            Tytul = "Sen na javie"
                        },
                        new
                        {
                            Id = 6,
                            Cena = 19.99m,
                            DataDodania = new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KategoriaId = 3,
                            Opis = "Film Dokumentalny",
                            Plakat = "Content/szybcyIWsciekli.jpg",
                            Rezyser = "Paweł Marciniak",
                            Tytul = "Szybcy i wściekli 21"
                        },
                        new
                        {
                            Id = 7,
                            Cena = 10.99m,
                            DataDodania = new DateTime(2023, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KategoriaId = 1,
                            Opis = "Bardzo ciekawy i interesujacy film",
                            Plakat = "Content/readyPlayerOne.jpg",
                            Rezyser = "Adam Małysz",
                            Tytul = "Ready Palyer One"
                        },
                        new
                        {
                            Id = 8,
                            Cena = 36.444m,
                            DataDodania = new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KategoriaId = 2,
                            Opis = "Film oparty na faktach",
                            Plakat = "Content/senNaJavie.jpg",
                            Rezyser = "Miłosz Jacoszek",
                            Tytul = "Sen na javie"
                        },
                        new
                        {
                            Id = 9,
                            Cena = 31.11m,
                            DataDodania = new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KategoriaId = 3,
                            Opis = "Film Dokumentalny",
                            Plakat = "Content/szybcyIWsciekli.jpg",
                            Rezyser = "Paweł Marciniak",
                            Tytul = "Szybcy i wściekli 21"
                        },
                        new
                        {
                            Id = 10,
                            Cena = 12.47m,
                            DataDodania = new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KategoriaId = 1,
                            Opis = "Bardzo ciekawy i interesujacy film",
                            Plakat = "Content/readyPlayerOne.jpg",
                            Rezyser = "Adam Małysz",
                            Tytul = "Ready Palyer One"
                        });
                });

            modelBuilder.Entity("ASPNET.Models.Kategoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Kategorie");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nazwa = "Sci=Fi",
                            Opis = "Filmy typu Sci-Fi"
                        },
                        new
                        {
                            Id = 2,
                            Nazwa = "fakty",
                            Opis = "Filmy oparte na faktach"
                        },
                        new
                        {
                            Id = 3,
                            Nazwa = "Akcji",
                            Opis = "Filmy pełne wybuchów"
                        });
                });

            modelBuilder.Entity("ASPNET.Models.Film", b =>
                {
                    b.HasOne("ASPNET.Models.Kategoria", "Kategoria")
                        .WithMany("Filmy")
                        .HasForeignKey("KategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategoria");
                });

            modelBuilder.Entity("ASPNET.Models.Kategoria", b =>
                {
                    b.Navigation("Filmy");
                });
#pragma warning restore 612, 618
        }
    }
}
