using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BhpApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class ImportZCSV : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AktualnyPoziom",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "CzyAktywny",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CzyKierownikZespolu",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataUrodzenia",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataZatrudnienia",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Dzial",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GrupaZaszeregowania",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "KodPocztowy",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "KontaktAwaryjnyNazwa",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "KontaktAwaryjnyTelefon",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Miasto",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Notatki",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NrBudynku",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NrLokalu",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NumerPracownika",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Pesel",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RodzajUmowy",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Stanowisko",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Ulica",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Zmiana",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AktualnyPoziom",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CzyAktywny",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CzyKierownikZespolu",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DataUrodzenia",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DataZatrudnienia",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Dzial",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "GrupaZaszeregowania",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "KodPocztowy",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "KontaktAwaryjnyNazwa",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "KontaktAwaryjnyTelefon",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Miasto",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Notatki",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NrBudynku",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NrLokalu",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NumerPracownika",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Pesel",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RodzajUmowy",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Stanowisko",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Ulica",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Zmiana",
                table: "AspNetUsers");
        }
    }
}
