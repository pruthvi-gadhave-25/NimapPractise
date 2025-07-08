using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeCrud_Sat.Migrations
{
    /// <inheritdoc />
    public partial class ForeignKeysFixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cities",
                newName: "CityId");

            migrationBuilder.AddColumn<int>(
                name: "CityId1",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CountryId1",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StateId1",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CityId1",
                table: "Employees",
                column: "CityId1");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CountryId1",
                table: "Employees",
                column: "CountryId1");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_StateId1",
                table: "Employees",
                column: "StateId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Cities_CityId1",
                table: "Employees",
                column: "CityId1",
                principalTable: "Cities",
                principalColumn: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Country_CountryId1",
                table: "Employees",
                column: "CountryId1",
                principalTable: "Country",
                principalColumn: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_States_StateId1",
                table: "Employees",
                column: "StateId1",
                principalTable: "States",
                principalColumn: "StateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Cities_CityId1",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Country_CountryId1",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_States_StateId1",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_CityId1",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_CountryId1",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_StateId1",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CityId1",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CountryId1",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "StateId1",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "CityId",
                table: "Cities",
                newName: "Id");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Employees",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
