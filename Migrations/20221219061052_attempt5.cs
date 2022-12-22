using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementSystem.Migrations
{
    public partial class attempt5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "EmployeeDetails");

            migrationBuilder.AddColumn<int>(
                name: "Genderid",
                table: "EmployeeDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDetails_Genderid",
                table: "EmployeeDetails",
                column: "Genderid",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeDetails_Gender_Genderid",
                table: "EmployeeDetails",
                column: "Genderid",
                principalTable: "Gender",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeDetails_Gender_Genderid",
                table: "EmployeeDetails");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeDetails_Genderid",
                table: "EmployeeDetails");

            migrationBuilder.DropColumn(
                name: "Genderid",
                table: "EmployeeDetails");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "EmployeeDetails",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
