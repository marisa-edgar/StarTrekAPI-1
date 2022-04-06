using Microsoft.EntityFrameworkCore.Migrations;

namespace StarTrek.Solution.Migrations
{
    public partial class ShipImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Starships",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Starships",
                keyColumn: "StarshipId",
                keyValue: 1,
                column: "Image",
                value: "https://media.discordapp.net/attachments/959946752771915856/961313799321821194/unknown.png");

            migrationBuilder.UpdateData(
                table: "Starships",
                keyColumn: "StarshipId",
                keyValue: 2,
                column: "Image",
                value: "https://media.discordapp.net/attachments/959946752771915856/961314079862034442/unknown.png");

            migrationBuilder.UpdateData(
                table: "Starships",
                keyColumn: "StarshipId",
                keyValue: 3,
                column: "Image",
                value: "https://media.discordapp.net/attachments/959946752771915856/961314199563280464/unknown.png");

            migrationBuilder.UpdateData(
                table: "Starships",
                keyColumn: "StarshipId",
                keyValue: 4,
                column: "Image",
                value: "https://media.discordapp.net/attachments/959946752771915856/961314317066711040/unknown.png");

            migrationBuilder.UpdateData(
                table: "Starships",
                keyColumn: "StarshipId",
                keyValue: 5,
                column: "Image",
                value: "https://media.discordapp.net/attachments/959946752771915856/961314925395980388/unknown.png?width=881&height=378");

            migrationBuilder.UpdateData(
                table: "Starships",
                keyColumn: "StarshipId",
                keyValue: 6,
                column: "Image",
                value: "https://media.discordapp.net/attachments/959946752771915856/961314692226252850/unknown.png?width=881&height=315");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Starships");
        }
    }
}
