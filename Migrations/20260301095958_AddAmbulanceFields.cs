using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicleValidator.Migrations
{
    /// <inheritdoc />
    public partial class AddAmbulanceFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Vehicle",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "TheLightsAreOn",
                table: "Vehicle",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "TheLightsAreOn",
                table: "Vehicle");
        }
    }
}
