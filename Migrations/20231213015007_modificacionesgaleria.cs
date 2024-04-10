using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiTienda.Migrations
{
    public partial class modificacionesgaleria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "url",
                table: "galeria");

            migrationBuilder.AddColumn<byte[]>(
                name: "archivo",
                table: "galeria",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "extension",
                table: "galeria",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "archivo",
                table: "galeria");

            migrationBuilder.DropColumn(
                name: "extension",
                table: "galeria");

            migrationBuilder.AddColumn<string>(
                name: "url",
                table: "galeria",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
