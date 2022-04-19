using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirlineAPI.Migrations
{
    public partial class creation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FlightMasters",
                columns: table => new
                {
                    FlightregistrationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Flightname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Economyseats = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Businessseats = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightMasters", x => x.FlightregistrationId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlightMasters");
        }
    }
}
