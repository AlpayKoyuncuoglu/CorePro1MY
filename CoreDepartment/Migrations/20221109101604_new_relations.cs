using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreDepartment.Migrations
{
    public partial class new_relations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Personels",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personels_DepartmentId",
                table: "Personels",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personels_Departments_DepartmentId",
                table: "Personels",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personels_Departments_DepartmentId",
                table: "Personels");

            migrationBuilder.DropIndex(
                name: "IX_Personels_DepartmentId",
                table: "Personels");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Personels");
        }
    }
}
