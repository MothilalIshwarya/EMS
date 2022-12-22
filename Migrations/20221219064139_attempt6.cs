using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementSystem.Migrations
{
    public partial class attempt6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Designation",
                table: "EmployeeDetails");

            migrationBuilder.AddColumn<int>(
                name: "designationId",
                table: "EmployeeDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Designation",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designation", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDetails_designationId",
                table: "EmployeeDetails",
                column: "designationId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeDetails_Designation_designationId",
                table: "EmployeeDetails",
                column: "designationId",
                principalTable: "Designation",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeDetails_Designation_designationId",
                table: "EmployeeDetails");

            migrationBuilder.DropTable(
                name: "Designation");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeDetails_designationId",
                table: "EmployeeDetails");

            migrationBuilder.DropColumn(
                name: "designationId",
                table: "EmployeeDetails");

            migrationBuilder.AddColumn<string>(
                name: "Designation",
                table: "EmployeeDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
