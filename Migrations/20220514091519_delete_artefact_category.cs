using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtefactsManager.Migrations
{
    public partial class delete_artefact_category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoriesArtefacts");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Artefacts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Artefacts_CategoryId",
                table: "Artefacts",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Artefacts_Categories_CategoryId",
                table: "Artefacts",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artefacts_Categories_CategoryId",
                table: "Artefacts");

            migrationBuilder.DropIndex(
                name: "IX_Artefacts_CategoryId",
                table: "Artefacts");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Artefacts");

            migrationBuilder.CreateTable(
                name: "CategoriesArtefacts",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ArtefactId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriesArtefacts", x => new { x.CategoryId, x.ArtefactId });
                    table.ForeignKey(
                        name: "FK_CategoriesArtefacts_Artefacts_ArtefactId",
                        column: x => x.ArtefactId,
                        principalTable: "Artefacts",
                        principalColumn: "ArtefactId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoriesArtefacts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoriesArtefacts_ArtefactId",
                table: "CategoriesArtefacts",
                column: "ArtefactId");
        }
    }
}
