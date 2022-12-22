using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementSystem.Migrations
{
    public partial class attempt7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeDetails_designations_designationId",
                table: "EmployeeDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeDetails_genders_Genderid",
                table: "EmployeeDetails");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeDetails_designationId",
                table: "EmployeeDetails");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeDetails_Genderid",
                table: "EmployeeDetails");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeDetailsId",
                table: "genders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "employeeDetailsId",
                table: "designations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_genders_EmployeeDetailsId",
                table: "genders",
                column: "EmployeeDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_designations_employeeDetailsId",
                table: "designations",
                column: "employeeDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_designations_EmployeeDetails_employeeDetailsId",
                table: "designations",
                column: "employeeDetailsId",
                principalTable: "EmployeeDetails",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_genders_EmployeeDetails_EmployeeDetailsId",
                table: "genders",
                column: "EmployeeDetailsId",
                principalTable: "EmployeeDetails",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_designations_EmployeeDetails_employeeDetailsId",
                table: "designations");

            migrationBuilder.DropForeignKey(
                name: "FK_genders_EmployeeDetails_EmployeeDetailsId",
                table: "genders");

            migrationBuilder.DropIndex(
                name: "IX_genders_EmployeeDetailsId",
                table: "genders");

            migrationBuilder.DropIndex(
                name: "IX_designations_employeeDetailsId",
                table: "designations");

            migrationBuilder.DropColumn(
                name: "EmployeeDetailsId",
                table: "genders");

            migrationBuilder.DropColumn(
                name: "employeeDetailsId",
                table: "designations");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDetails_designationId",
                table: "EmployeeDetails",
                column: "designationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDetails_Genderid",
                table: "EmployeeDetails",
                column: "Genderid",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeDetails_designations_designationId",
                table: "EmployeeDetails",
                column: "designationId",
                principalTable: "designations",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeDetails_genders_Genderid",
                table: "EmployeeDetails",
                column: "Genderid",
                principalTable: "genders",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
