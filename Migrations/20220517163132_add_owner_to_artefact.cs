using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtefactsManager.Migrations
{
    public partial class add_owner_to_artefact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attributes_Users_OwnerUserId",
                table: "Attributes");

            migrationBuilder.DropIndex(
                name: "IX_Attributes_OwnerUserId",
                table: "Attributes");

            migrationBuilder.DropColumn(
                name: "OwnerUserId",
                table: "Attributes");

            migrationBuilder.AddColumn<int>(
                name: "OwnerUserId",
                table: "Artefacts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Artefacts_OwnerUserId",
                table: "Artefacts",
                column: "OwnerUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Artefacts_Users_OwnerUserId",
                table: "Artefacts",
                column: "OwnerUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artefacts_Users_OwnerUserId",
                table: "Artefacts");

            migrationBuilder.DropIndex(
                name: "IX_Artefacts_OwnerUserId",
                table: "Artefacts");

            migrationBuilder.DropColumn(
                name: "OwnerUserId",
                table: "Artefacts");

            migrationBuilder.AddColumn<int>(
                name: "OwnerUserId",
                table: "Attributes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Attributes_OwnerUserId",
                table: "Attributes",
                column: "OwnerUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attributes_Users_OwnerUserId",
                table: "Attributes",
                column: "OwnerUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
