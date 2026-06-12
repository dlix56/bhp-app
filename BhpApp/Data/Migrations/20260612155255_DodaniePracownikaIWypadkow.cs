using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BhpApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class DodaniePracownikaIWypadkow : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CzyNaUrlopie",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Imie",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nazwisko",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Wypadki",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WspolrzednaX = table.Column<double>(type: "float", nullable: false),
                    WspolrzednaY = table.Column<double>(type: "float", nullable: false),
                    CzyPodziemne = table.Column<bool>(type: "bit", nullable: false),
                    DataZgloszenia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZglaszajacyId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wypadki", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wypadki_AspNetUsers_ZglaszajacyId",
                        column: x => x.ZglaszajacyId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Wypadki_ZglaszajacyId",
                table: "Wypadki",
                column: "ZglaszajacyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Wypadki");

            migrationBuilder.DropColumn(
                name: "CzyNaUrlopie",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Imie",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Nazwisko",
                table: "AspNetUsers");
        }
    }
}
