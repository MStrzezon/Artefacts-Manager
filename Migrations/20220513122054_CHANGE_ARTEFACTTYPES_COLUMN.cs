using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtefactsManager.Migrations
{
    public partial class CHANGE_ARTEFACTTYPES_COLUMN : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArtefactName",
                table: "ArtefactsTypes");

            migrationBuilder.AddColumn<string>(
                name: "TypeName",
                table: "ArtefactsTypes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TypeName",
                table: "ArtefactsTypes");

            migrationBuilder.AddColumn<string>(
                name: "ArtefactName",
                table: "ArtefactsTypes",
                type: "text",
                nullable: true);
        }
    }
}
