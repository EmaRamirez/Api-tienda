using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiTienda.Migrations
{
    public partial class inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "editoriales",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_editoriales", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "mangaInfo",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    autor = table.Column<string>(nullable: true),
                    demografia = table.Column<string>(nullable: true),
                    cantidadTomo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mangaInfo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "descriptionMangas",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: false),
                    tomoNro = table.Column<int>(nullable: false),
                    price = table.Column<double>(nullable: false),
                    summary = table.Column<string>(nullable: true),
                    numberPages = table.Column<int>(nullable: false),
                    idEditorial = table.Column<int>(nullable: false),
                    idMangaInfo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_descriptionMangas", x => x.id);
                    table.ForeignKey(
                        name: "FK_descriptionMangas_editoriales_idEditorial",
                        column: x => x.idEditorial,
                        principalTable: "editoriales",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_descriptionMangas_mangaInfo_idMangaInfo",
                        column: x => x.idMangaInfo,
                        principalTable: "mangaInfo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_descriptionMangas_idEditorial",
                table: "descriptionMangas",
                column: "idEditorial");

            migrationBuilder.CreateIndex(
                name: "IX_descriptionMangas_idMangaInfo",
                table: "descriptionMangas",
                column: "idMangaInfo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "descriptionMangas");

            migrationBuilder.DropTable(
                name: "editoriales");

            migrationBuilder.DropTable(
                name: "mangaInfo");
        }
    }
}
