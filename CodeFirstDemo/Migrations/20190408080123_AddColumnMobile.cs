using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstDemo.Migrations
{
    public partial class AddColumnMobile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmployeeMobile",
                table: "Employees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeMobile",
                table: "Employees");
        }
    }
}
