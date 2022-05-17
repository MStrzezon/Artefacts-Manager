using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtefactsManager.Migrations
{
    public partial class edit_permission_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryOrType",
                table: "Permissions");

            migrationBuilder.DropColumn(
                name: "PermissionType",
                table: "Permissions");

            migrationBuilder.AddColumn<string>(
                name: "CategoryName",
                table: "Permissions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypeName",
                table: "Permissions",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryName",
                table: "Permissions");

            migrationBuilder.DropColumn(
                name: "TypeName",
                table: "Permissions");

            migrationBuilder.AddColumn<string>(
                name: "CategoryOrType",
                table: "Permissions",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PermissionType",
                table: "Permissions",
                type: "text",
                nullable: true);
        }
    }
}
