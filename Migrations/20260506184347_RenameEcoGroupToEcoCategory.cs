using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicleValidator.Migrations
{
    /// <inheritdoc />
    public partial class RenameEcoGroupToEcoCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FuelType",
                table: "Vehicle");

            migrationBuilder.AddColumn<int>(
                name: "Fuel",
                table: "Vehicle",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fuel",
                table: "Vehicle");

            migrationBuilder.AddColumn<string>(
                name: "FuelType",
                table: "Vehicle",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
