using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPNET.Migrations
{
    public partial class FilmImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Plakat",
                table: "Filmy",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataDodania", "Plakat" },
                values: new object[] { new DateTime(2024, 4, 17, 10, 15, 10, 477, DateTimeKind.Local).AddTicks(7328), "Content/readyPlayerOne.jpg" });

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 2,
                column: "Plakat",
                value: "Content/senNaJavie.jpg");

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 3,
                column: "Plakat",
                value: "Content/szybcyIWsciekli.jpg");

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 4,
                column: "Plakat",
                value: "Content/readyPlayerOne.jpg");

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 5,
                column: "Plakat",
                value: "Content/senNaJavie.jpg");

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 6,
                column: "Plakat",
                value: "Content/szybcyIWsciekli.jpg");

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 7,
                column: "Plakat",
                value: "Content/readyPlayerOne.jpg");

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 8,
                column: "Plakat",
                value: "Content/senNaJavie.jpg");

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 9,
                column: "Plakat",
                value: "Content/szybcyIWsciekli.jpg");

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 10,
                column: "Plakat",
                value: "Content/readyPlayerOne.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Plakat",
                table: "Filmy");

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataDodania",
                value: new DateTime(2024, 3, 6, 10, 41, 7, 760, DateTimeKind.Local).AddTicks(2619));
        }
    }
}
