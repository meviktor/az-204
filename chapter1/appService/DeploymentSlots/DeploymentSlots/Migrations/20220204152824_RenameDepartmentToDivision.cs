using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeploymentSlots.Migrations
{
    public partial class RenameDepartmentToDivision : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Department",
                table: "Users",
                newName: "Division");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Division",
                table: "Users",
                newName: "Department");
        }
    }
}
