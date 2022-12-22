using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementSystem.Migrations
{
    public partial class sample : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeDetails_Designation_designationId",
                table: "EmployeeDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeDetails_Gender_Genderid",
                table: "EmployeeDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gender",
                table: "Gender");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Designation",
                table: "Designation");

            migrationBuilder.RenameTable(
                name: "Gender",
                newName: "genders");

            migrationBuilder.RenameTable(
                name: "Designation",
                newName: "designations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_genders",
                table: "genders",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_designations",
                table: "designations",
                column: "id");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeDetails_designations_designationId",
                table: "EmployeeDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeDetails_genders_Genderid",
                table: "EmployeeDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_genders",
                table: "genders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_designations",
                table: "designations");

            migrationBuilder.RenameTable(
                name: "genders",
                newName: "Gender");

            migrationBuilder.RenameTable(
                name: "designations",
                newName: "Designation");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gender",
                table: "Gender",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Designation",
                table: "Designation",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeDetails_Designation_designationId",
                table: "EmployeeDetails",
                column: "designationId",
                principalTable: "Designation",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeDetails_Gender_Genderid",
                table: "EmployeeDetails",
                column: "Genderid",
                principalTable: "Gender",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
