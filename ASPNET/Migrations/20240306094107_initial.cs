using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPNET.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategorie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Filmy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tytul = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rezyser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Cena = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DataDodania = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Filmy_Kategorie_KategoriaId",
                        column: x => x.KategoriaId,
                        principalTable: "Kategorie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kategorie",
                columns: new[] { "Id", "Nazwa", "Opis" },
                values: new object[] { 1, "Sci=Fi", "Filmy typu Sci-Fi" });

            migrationBuilder.InsertData(
                table: "Kategorie",
                columns: new[] { "Id", "Nazwa", "Opis" },
                values: new object[] { 2, "fakty", "Filmy oparte na faktach" });

            migrationBuilder.InsertData(
                table: "Kategorie",
                columns: new[] { "Id", "Nazwa", "Opis" },
                values: new object[] { 3, "Akcji", "Filmy pełne wybuchów" });

            migrationBuilder.InsertData(
                table: "Filmy",
                columns: new[] { "Id", "Cena", "DataDodania", "KategoriaId", "Opis", "Rezyser", "Tytul" },
                values: new object[,]
                {
                    { 1, 12.36m, new DateTime(2024, 3, 6, 10, 41, 7, 760, DateTimeKind.Local).AddTicks(2619), 1, "Bardzo ciekawy i interesujacy film", "Adam Małysz", "Ready Palyer One" },
                    { 2, 24.94m, new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Film oparty na faktach", "Miłosz Jacoszek", "Sen na javie" },
                    { 3, 29.99m, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Film Dokumentalny", "Paweł Marciniak", "Szybcy i wściekli 21" },
                    { 4, 15.68m, new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Bardzo ciekawy i interesujacy film", "Adam Małysz", "Ready Palyer One" },
                    { 5, 50.17m, new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Film oparty na faktach", "Miłosz Jacoszek", "Sen na javie" },
                    { 6, 19.99m, new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Film Dokumentalny", "Paweł Marciniak", "Szybcy i wściekli 21" },
                    { 7, 10.99m, new DateTime(2023, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Bardzo ciekawy i interesujacy film", "Adam Małysz", "Ready Palyer One" },
                    { 8, 36.444m, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Film oparty na faktach", "Miłosz Jacoszek", "Sen na javie" },
                    { 9, 31.11m, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Film Dokumentalny", "Paweł Marciniak", "Szybcy i wściekli 21" },
                    { 10, 12.47m, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Bardzo ciekawy i interesujacy film", "Adam Małysz", "Ready Palyer One" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Filmy_KategoriaId",
                table: "Filmy",
                column: "KategoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filmy");

            migrationBuilder.DropTable(
                name: "Kategorie");
        }
    }
}
