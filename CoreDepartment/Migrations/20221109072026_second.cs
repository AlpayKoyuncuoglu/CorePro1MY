using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreDepartment.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Departmants",
                table: "Departmants");

            migrationBuilder.DropColumn(
                name: "DepartmantName",
                table: "Departmants");

            migrationBuilder.RenameTable(
                name: "Departmants",
                newName: "Departments");

            migrationBuilder.AddColumn<string>(
                name: "DepartmentName",
                table: "Departments",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "DepartmentName",
                table: "Departments");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "Departmants");

            migrationBuilder.AddColumn<string>(
                name: "DepartmantName",
                table: "Departmants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departmants",
                table: "Departmants",
                column: "Id");
        }
    }
}
