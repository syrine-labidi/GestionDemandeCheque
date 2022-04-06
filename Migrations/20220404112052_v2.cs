using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GchequeWebApp.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ID_personnel",
                table: "roles");

            migrationBuilder.RenameColumn(
                name: "type_roles",
                table: "roles",
                newName: "name_roles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name_roles",
                table: "roles",
                newName: "type_roles");

            migrationBuilder.AddColumn<string>(
                name: "ID_personnel",
                table: "roles",
                type: "varchar(10)",
                unicode: false,
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }
    }
}
