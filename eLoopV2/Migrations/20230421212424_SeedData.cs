using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eLoopV2.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ElectricCars_ElectricCarLocations_LocationId",
                table: "ElectricCars");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "ElectricCarLocations");

            migrationBuilder.DropColumn(
                name: "City",
                table: "ElectricCarLocations");

            migrationBuilder.DropColumn(
                name: "State",
                table: "ElectricCarLocations");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "ElectricCarLocations");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "ElectricCars",
                newName: "LocationID");

            migrationBuilder.RenameIndex(
                name: "IX_ElectricCars_LocationId",
                table: "ElectricCars",
                newName: "IX_ElectricCars_LocationID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ElectricCarLocations",
                newName: "ID");

            migrationBuilder.AddColumn<int>(
                name: "ReservationId",
                table: "Reservations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ReservationId",
                table: "Reservations",
                column: "ReservationId");

            migrationBuilder.AddForeignKey(
                name: "FK_ElectricCars_ElectricCarLocations_LocationID",
                table: "ElectricCars",
                column: "LocationID",
                principalTable: "ElectricCarLocations",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Reservations_ReservationId",
                table: "Reservations",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ElectricCars_ElectricCarLocations_LocationID",
                table: "ElectricCars");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Reservations_ReservationId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_ReservationId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "ReservationId",
                table: "Reservations");

            migrationBuilder.RenameColumn(
                name: "LocationID",
                table: "ElectricCars",
                newName: "LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_ElectricCars_LocationID",
                table: "ElectricCars",
                newName: "IX_ElectricCars_LocationId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "ElectricCarLocations",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "ElectricCarLocations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "ElectricCarLocations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "ElectricCarLocations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "ElectricCarLocations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_ElectricCars_ElectricCarLocations_LocationId",
                table: "ElectricCars",
                column: "LocationId",
                principalTable: "ElectricCarLocations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
