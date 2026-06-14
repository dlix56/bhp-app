using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BhpApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class PolaProtokolu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataWypadku",
                table: "Wypadki",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KomentarzPoszkodowanego",
                table: "Wypadki",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PoszkodowanyId",
                table: "Wypadki",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Zmiana",
                table: "Wypadki",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Wypadki_PoszkodowanyId",
                table: "Wypadki",
                column: "PoszkodowanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Wypadki_AspNetUsers_PoszkodowanyId",
                table: "Wypadki",
                column: "PoszkodowanyId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wypadki_AspNetUsers_PoszkodowanyId",
                table: "Wypadki");

            migrationBuilder.DropIndex(
                name: "IX_Wypadki_PoszkodowanyId",
                table: "Wypadki");

            migrationBuilder.DropColumn(
                name: "DataWypadku",
                table: "Wypadki");

            migrationBuilder.DropColumn(
                name: "KomentarzPoszkodowanego",
                table: "Wypadki");

            migrationBuilder.DropColumn(
                name: "PoszkodowanyId",
                table: "Wypadki");

            migrationBuilder.DropColumn(
                name: "Zmiana",
                table: "Wypadki");
        }
    }
}
