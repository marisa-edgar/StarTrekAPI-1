using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarTrek.Solution.Migrations
{
    public partial class Starships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Characters",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Starships",
                columns: table => new
                {
                    StarshipId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ShipModel = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ShipClass = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Captain = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Launch = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Starships", x => x.StarshipId);
                });

            migrationBuilder.InsertData(
                table: "Starships",
                columns: new[] { "StarshipId", "Captain", "Launch", "ShipClass", "ShipModel" },
                values: new object[,]
                {
                    { 1, "James T Kirk", "2245", "Constitution", "USS Enterprise NCC-1701" },
                    { 2, "James T Kirk", "2286", "Constitution", "USS Enterprise NCC-1701-A" },
                    { 3, "James T Kirk", "2293", "Excelsior", "USS Enterprise NCC-1701-B" },
                    { 4, "James T Kirk", "2332", "Ambassador", "USS Enterprise NCC-1701-C" },
                    { 5, "Jean Luc Picard", "2363", "Galaxy", "USS Enterprise NCC-1701-D" },
                    { 6, "Jean Luc Picard", "2372", "Sovereign", "USS Enterprise NCC-1701-E" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Starships");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Characters");
        }
    }
}
