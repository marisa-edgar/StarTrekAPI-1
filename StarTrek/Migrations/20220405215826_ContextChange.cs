using Microsoft.EntityFrameworkCore.Migrations;

namespace StarTrek.Solution.Migrations
{
    public partial class ContextChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 27,
                column: "Description",
                value: "The Tomed Incident was an alleged terrorist attack by extremist Romulan Admiral Aventeer Vokar and 5 crewmates. Their ship impacted with an asteroid base in the Foxtrot center and and its quantum singularity drive caused a massive explosion disrupting space-time throughout the sector and wiping out dozens of asteroid bases and at least one starship, the USS Agamemnon. Thousands of lives were said to be lost. This incident led to the Klingon Empire siding with Federation Forces and the retreat of the Imperial Fleet. Two months later the Treaty of Alegron is signed banning the development of cloaking weapons in the Federation in exchange for the Star Empire's agreement to withdraw behind its borders and to recall all of its diplomatic missions and citizens.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 27,
                column: "Description",
                value: "The Tomed Incident was an alleged terrorist attack by extremist Romulan Admiral Aventeer Vokar and 5 crewmates. Their ship impacted with an asteroid base in the Foxtrot center and and its quantum singularity drive caused a massive explosion disrupting space-time throughout the sector and wiping out dozens of asteroid bases and at least one starship, the USS Agamemnon. Thousands of lives were said to be lost. In reality this attack was planned by Federation Intelligence and the only lives lost were the 6 Romulans. This incident led to the Klingon Empire siding with Federation Forces and the retreat of the Imperial Fleet. Two months later the Treaty of Alegron is signed banning the development of cloaking weapons in the Federation in exchange for the Star Empire's agreement to withdraw behind its borders and to recall all of its diplomatic missions and citizens.");
        }
    }
}
