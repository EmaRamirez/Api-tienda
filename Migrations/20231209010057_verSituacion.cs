using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiTienda.Migrations
{
    public partial class verSituacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_descriptionMangas_editoriales_editorialidEditorial",
                table: "descriptionMangas");

            migrationBuilder.DropForeignKey(
                name: "FK_descriptionMangas_mangaInfo_mangaInfoidMangaInfo",
                table: "descriptionMangas");

            migrationBuilder.DropForeignKey(
                name: "FK_mangaInfo_editoriales_idEditorial",
                table: "mangaInfo");

            migrationBuilder.DropIndex(
                name: "IX_mangaInfo_idEditorial",
                table: "mangaInfo");

            migrationBuilder.DropIndex(
                name: "IX_descriptionMangas_editorialidEditorial",
                table: "descriptionMangas");

            migrationBuilder.DropIndex(
                name: "IX_descriptionMangas_mangaInfoidMangaInfo",
                table: "descriptionMangas");

            migrationBuilder.DropColumn(
                name: "editorialidEditorial",
                table: "descriptionMangas");

            migrationBuilder.DropColumn(
                name: "mangaInfoidMangaInfo",
                table: "descriptionMangas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "editorialidEditorial",
                table: "descriptionMangas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "mangaInfoidMangaInfo",
                table: "descriptionMangas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_mangaInfo_idEditorial",
                table: "mangaInfo",
                column: "idEditorial");

            migrationBuilder.CreateIndex(
                name: "IX_descriptionMangas_editorialidEditorial",
                table: "descriptionMangas",
                column: "editorialidEditorial");

            migrationBuilder.CreateIndex(
                name: "IX_descriptionMangas_mangaInfoidMangaInfo",
                table: "descriptionMangas",
                column: "mangaInfoidMangaInfo");

            migrationBuilder.AddForeignKey(
                name: "FK_descriptionMangas_editoriales_editorialidEditorial",
                table: "descriptionMangas",
                column: "editorialidEditorial",
                principalTable: "editoriales",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_descriptionMangas_mangaInfo_mangaInfoidMangaInfo",
                table: "descriptionMangas",
                column: "mangaInfoidMangaInfo",
                principalTable: "mangaInfo",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_mangaInfo_editoriales_idEditorial",
                table: "mangaInfo",
                column: "idEditorial",
                principalTable: "editoriales",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
