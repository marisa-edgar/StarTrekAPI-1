using Microsoft.EntityFrameworkCore.Migrations;

namespace StarTrek.Solution.Migrations
{
    public partial class SeedImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 1,
                column: "Image",
                value: "https://discord.com/channels/@me/959946752771915856/961299293480812577");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 1,
                column: "Image",
                value: null);
        }
    }
}
