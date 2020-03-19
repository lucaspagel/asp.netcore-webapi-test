using Microsoft.EntityFrameworkCore.Migrations;

namespace Reserva.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReservationDetails",
                columns: table => new
                {
                    ResID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "varchar (100)", nullable: false),
                    DestinationName = table.Column<string>(type: "varchar (100)", nullable: false),
                    DepartureName = table.Column<string>(type: "varchar (100)", nullable: false),
                    TravelDate = table.Column<string>(type: "varchar (5)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationDetails", x => x.ResID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReservationDetails");
        }
    }
}
