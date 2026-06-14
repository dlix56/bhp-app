using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BhpApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class DodanieStrefy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Strefa",
                table: "Wypadki",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Strefa",
                table: "Wypadki");
        }
    }
}
