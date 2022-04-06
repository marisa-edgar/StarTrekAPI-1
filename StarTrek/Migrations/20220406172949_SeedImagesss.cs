using Microsoft.EntityFrameworkCore.Migrations;

namespace StarTrek.Solution.Migrations
{
    public partial class SeedImagesss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 10,
                column: "Image",
                value: "https://cdn.discordapp.com/attachments/959946752771915856/961296578591727676/star-trek-worf-michael-dorn-1200x675.jpg");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 12,
                column: "Image",
                value: "https://cdn.discordapp.com/attachments/959946752771915856/961298612795605032/dianna-troi.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 10,
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 12,
                column: "Image",
                value: "https://cdn.discordapp.com/attachments/959946752771915856/961296578591727676/star-trek-worf-michael-dorn-1200x675.jpg");
        }
    }
}
