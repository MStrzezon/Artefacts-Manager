using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtefactsManager.Migrations
{
    public partial class add_owner_to_attribute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OwnerUserId",
                table: "Attributes",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
