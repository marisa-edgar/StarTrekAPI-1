using Microsoft.EntityFrameworkCore.Migrations;

namespace StarTrek.Solution.Migrations
{
    public partial class SeedImagess : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 1,
                column: "Image",
                value: "https://cdn.discordapp.com/attachments/959946752771915856/961290789948895242/captain-kirk.jpg");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 2,
                column: "Image",
                value: "https://cdn.discordapp.com/attachments/959946752771915856/961290790510952478/Hikaru-Sulu-star-trek-the-movies-13224553-900-1330.jpg");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 3,
                column: "Image",
                value: "https://cdn.discordapp.com/attachments/959946752771915856/961290791479820308/Nyota-Uhura-star-trek-the-movies-13224660-580-901.jpg");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 4,
                column: "Image",
                value: "https://cdn.discordapp.com/attachments/959946752771915856/961290790888415322/Mr-Spock-star-trek-the-movies-13224893-800-1100.jpg");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 5,
                column: "Image",
                value: "https://cdn.discordapp.com/attachments/959946752771915856/961290790221516810/Dr-Leonard-McCoy-star-trek-the-movies-13224707-800-990.jpg");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 6,
                column: "Image",
                value: "https://cdn.discordapp.com/attachments/959946752771915856/961299292981710879/montgomery-scott.png");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 7,
                column: "Image",
                value: "https://cdn.discordapp.com/attachments/959946752771915856/961290791173623818/Pavel-Chekov-star-trek-the-movies-13223605-580-901.jpg");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 8,
                column: "Image",
                value: "https://cdn.discordapp.com/attachments/959946752771915856/961297643164799007/jean-luc-picard.png");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 9,
                column: "Image",
                value: "https://cdn.discordapp.com/attachments/959946752771915856/961297070139007046/41Td62h3vL._AC_.jpg");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 10,
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 11,
                column: "Image",
                value: "https://cdn.discordapp.com/attachments/959946752771915856/961298256887959582/william-t-riker.png");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 12,
                column: "Image",
                value: "https://cdn.discordapp.com/attachments/959946752771915856/961296578591727676/star-trek-worf-michael-dorn-1200x675.jpg");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 13,
                column: "Image",
                value: "https://cdn.discordapp.com/attachments/959946752771915856/961295616061882408/unknown.png");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 14,
                column: "Image",
                value: "https://cdn.discordapp.com/attachments/959946752771915856/961295847574868069/unknown.png");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 15,
                column: "Image",
                value: "https://cdn.discordapp.com/attachments/959946752771915856/961296050252054648/unknown.png");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 16,
                column: "Image",
                value: "https://cdn.discordapp.com/attachments/959946752771915856/961295041601609840/unknown.png");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 17,
                column: "Image",
                value: "https://cdn.discordapp.com/attachments/959946752771915856/961291743582625802/unknown.png");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 18,
                column: "Image",
                value: "https://cdn.discordapp.com/attachments/959946752771915856/961294534761914458/unknown.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 1,
                column: "Image",
                value: "https://cdn.discordapp.com/attachments/959946752771915856/961298256887959582/william-t-riker.png");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 2,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 3,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 4,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 5,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 6,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 7,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 8,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 9,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 10,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 11,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 12,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 13,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 14,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 15,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 16,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 17,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 18,
                column: "Image",
                value: null);
        }
    }
}
