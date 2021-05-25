using Microsoft.EntityFrameworkCore.Migrations;

namespace Parcial02.Migrations
{
    public partial class Mo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Users",
                newName: "UserName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Users",
                newName: "FullName");
        }
    }
}
