using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiTienda.Migrations
{
    public partial class navegacionInfoMangaDescricion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "idEditorial",
                table: "mangaInfo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_mangaInfo_idEditorial",
                table: "mangaInfo",
                column: "idEditorial");

            migrationBuilder.AddForeignKey(
                name: "FK_mangaInfo_editoriales_idEditorial",
                table: "mangaInfo",
                column: "idEditorial",
                principalTable: "editoriales",
                principalColumn: "id",
                onDelete: ReferentialAction.NoAction);

			
		}

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_mangaInfo_editoriales_idEditorial",
                table: "mangaInfo");

            migrationBuilder.DropIndex(
                name: "IX_mangaInfo_idEditorial",
                table: "mangaInfo");

            migrationBuilder.DropColumn(
                name: "idEditorial",
                table: "mangaInfo");
        }
    }
}
