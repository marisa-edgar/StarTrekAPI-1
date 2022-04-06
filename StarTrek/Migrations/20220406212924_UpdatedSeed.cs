using Microsoft.EntityFrameworkCore.Migrations;

namespace StarTrek.Solution.Migrations
{
    public partial class UpdatedSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 8,
                column: "Bio",
                value: "Captain of the USS Enterprise NCC-1701-E");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 9,
                column: "Bio",
                value: "Chief Engineer on the USS Enterprise NCC-1701-E");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 10,
                column: "Bio",
                value: "Chief of Security on the USS Enterprise NCC-1701-E");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 11,
                column: "Bio",
                value: "Commander on the USS Enterprise NCC 1701-E");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 12,
                columns: new[] { "Bio", "Name" },
                values: new object[] { "Counselor on the USS Enterprise NCC-1701-E", "Deanna Troi" });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 13,
                columns: new[] { "Bio", "Name" },
                values: new object[] { "Former Chief of Security on the USS Enterprise NCC-1701-E", "Natasha Yar" });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 14,
                column: "Bio",
                value: "Chief Medical Officer on the USS Enterprise NCC-1701-E");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 15,
                column: "Bio",
                value: "Ensign aboard the USS Enterprise-NCC-1701-E, training to become a Starfleet Officer.");

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 1,
                column: "Description",
                value: "The crew of the USS Enterprise return back to Earth after their voyage to save Spock. Only to find an alien life-form probing Earth. Earth is then destroyed by this entity. The crew are forced to find a way to travel back in time to prevent Earth's destruction.");

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 2,
                column: "Description",
                value: "World War III starts on Earth. Eco-Terrorists attack the natons of the world. 37 Million people die.");

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 5,
                column: "Description",
                value: "Zefram Cochrane successfully launches the first spacecraft using warp technology into space, The Pheonix. A Vulcan ship passing by Earth's solar system sees this launch and lands on Earth to meet humanity. The events of this date are rewritten when the crew of the USS Enterprise E have to travel back in time to stop the Borg.");

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 8,
                column: "Description",
                value: "Start of the Earth and Ramulan War.");

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 9,
                column: "Description",
                value: "The Earth-Ramulan War comes to a close with the Battle of Cheron. Earth inflicts a humiliating defeat to the Romulans. The Ramulan Neutral Zone is then later established.");

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 11,
                column: "Description",
                value: "Sarek, the father of Spock is born.");

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 15,
                column: "Description",
                value: "James T. Kirk and Nyota Uhura are born.");

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 17,
                column: "Description",
                value: "The USS Enterprise is refitted and renamed to the USS Enterprise NCC-1701. It launches on a second five-year mission under the command of Captain Christopher Pike.");

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 18,
                column: "Description",
                value: "James T Kirk is appointed to Captain of the USS Enterprise NCC-1701 and his crew are assigned: Montgomery Scott 'Scotty' appointed Chief Engineer. Leonard McCoy 'Bones' appointed Chief Medical Officer. Hikaru Sulu appointed Helmsman. Nyota Uhura appointed Chief Communications Officer. Pavel Chekov appointed First Officer. Spock, former crewmate under Christopher Pike is appointed Chief Science Officer. The Enterprise sets out on a 5 year mission to chart out planets, explore and discover new life forms.");

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 20,
                column: "Description",
                value: "Admiral Kirk and a new crew take off on a new 5 year voyage in the newly refitted Enterprise, under Captain . An unknown life-form named V'ger is causing destruction in Klingon space and is approaching the Earth. Kirk leads a mission to investigate and hopefully stop this threat. The threat is avoided but at great cost; Captain William Decker and Ship Navigator Ilia pass away in the line of duty.");

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 21,
                column: "Description",
                value: "The USS Enterprise UCC-1701 returns from it's voyage and is retired from active duty. It is repurposed as a training vessel for new cadets.");

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 22,
                column: "Description",
                value: "Admiral Kirk oversees a training exercise aboard the Enterprise NCC-1701. The crew receives a distress call from a research facility. It turns out Kahn, an old enemy of Captain Kirk and crew has taken a science vessel captive. Kahn is stopped, but Spock dies in attempt to save the crew of the Enterprise. On return home, the Enterprise is marked for permanent decommission. After learning that Spock's soul is still alive inside of Dr. McCoy, the crew steal the Enterprise against permission to return to the planet where Spock's body was left, to revive him. The Enterprise is destroyed to prevent it from landing in enemy hands. The crew of the Enterprise steal a Klingon Warbird vessel.");

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 25,
                column: "Description",
                value: "The Klingon moon of Praxis is destroyed. The Klingon Empire decides to make peace with the Federation and a peace treaty ceremony is held. Opposing Klingon attack the location. The Enterprise NCC-1701-A intervene and stop the attack. Later, Admiral Kirk joins the newly built Enterprise NCC 1701-B and it's Captain, John Harriman, on a first launch ceremony. The during a routine inspection of the ship, it is struck by the Nexus and Kirk is lost, and presumed dead.");

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 26,
                column: "Description",
                value: "Jean-Luc Picard is born.");

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 27,
                column: "Description",
                value: "The Tomed Incident occurs. Alleged terrorists led by extremist Romulan Admiral Aventeer Vokar and 5 crewmates attack an asteroid base in the Foxtrot center. It's collision with the quantum singularity drive causes a massive explosion, disrupting space-time throughout the sector and wiping out dozens of asteroid bases. Thousands of lives were said to be lost. This incident leads to the Klingon Empire siding with the Federation and the retreat of the Imperial Fleet. Two months later the Treaty of Alegron is signed banning the development of cloaking weapons in the Federation in exchange for the Star Empire's agreement to withdraw behind its borders and to recall all of its diplomatic missions and citizens.");

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 28,
                column: "Description",
                value: "Beverly Howard (married name: Crusher) is born.");

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 29,
                column: "Description",
                value: "Jean-Luc Picard graduates from Starfleet Academy.");

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 31,
                columns: new[] { "Date", "Description" },
                values: new object[] { 2334, "The Enterprise-C, under the command of Captain Rachel Garrett, is destroyed defending a Klingon settlement on Narendra III under attack from Romulans. Due to the Enterprise-C's sacrifice, a new era of more open communication begins between the Federation and the Klingon Empire, leading to a formalized alliance." });

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 32,
                columns: new[] { "Date", "Description" },
                values: new object[] { 2335, "Geordi La Forge and William T. Riker are born." });

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 33,
                columns: new[] { "Date", "Description" },
                values: new object[] { 2336, "Deanna Troi is born." });

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 34,
                columns: new[] { "Date", "Description" },
                values: new object[] { 2337, "Tasha Yar is born." });

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 35,
                columns: new[] { "Date", "Description" },
                values: new object[] { 2340, "Worf, son of Mogh, is born." });

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 36,
                columns: new[] { "Date", "Description" },
                values: new object[] { 2346, "Worf's biological parents are killed by Romulans in the Khitomer massacre. Worf at the age of 6 is adopted by a human couple." });

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 37,
                columns: new[] { "Date", "Description" },
                values: new object[] { 2355, "The USS Stargazer is attacked by an unknown vessel in the Maxia Zeta system. Jean-Luc Picard wins the confrontation by devising a tactic which becomes known as the Picard Manoeuvre. However, due to damage suffered during the battle, the crew are forced to abandon ship." });

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 38,
                columns: new[] { "Date", "Description" },
                values: new object[] { 2357, "Worf, joins the Starfleet Academy. He is the first Klingon in Star Fleet." });

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 39,
                columns: new[] { "Date", "Description" },
                values: new object[] { 2363, "USS Enterprise NCC-1701-D, the third Galaxy-class starship is launched from the Utopia Planitia shipyards and becomes the Federation's new flagship." });

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 40,
                columns: new[] { "Date", "Description" },
                values: new object[] { 2364, "The USS Enterprise NCC-1701-D is deployed on a 5 year mission with Jean-Luc Picard appointed as it's captain. William T. Riker is appointed Commander. Data is appointed his Operations Officer. Geordi La Forge is appointed Chief Engineer. Tasha Yar is appointed Chief of Security. Worf Rozhenko is appointed to Chief of Security on Tasha Yar's death. Beverly Crusher is appointed Chief Medical Officer. Deanna Troi is appointed Ship Counsellor. Wesley Crusher is later appointed to Acting Ensign." });

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 41,
                columns: new[] { "Date", "Description" },
                values: new object[] { 2365, "The Stargazer is recovered." });

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 42,
                column: "Description",
                value: "The Borg invade the Enterprise and take Captain Jean Luc Picard hostage. He is assimilated into Lucutis of Borg. The battle results in the loss of 39 Starfleet vessels and over 11,000 lives. With the task force lost, the Borg continue to Earth. Picard is rescued and the Borg cube is destroyed via the actions of the crew of the USS Enterprise NCC-1701-D.");

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 43,
                columns: new[] { "Date", "Description" },
                values: new object[] { 2371, "Chasing after the Nexus to stop a terrorist seeking to use it's power to send time into a loop, the USS Enterprise NCC-1701-D's stardrive section is destroyed by a warp core breach. The saucer section containing the crew makes a forced landing on Veridian III. James T. Kirk, thought to be dead is found inside the temporal continuum of the Nexus. Jean Luc Picard and James T Kirk fight to stop the terrorist. Kirk is killed in action defending Jean Luc Picard." });

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 44,
                columns: new[] { "Date", "Description" },
                values: new object[] { 2372, "Sovereign-class USS Enterprise NCC-1701-E is launched under the command of Captain Jean-Luc Picard." });

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 45,
                columns: new[] { "Date", "Description" },
                values: new object[] { 2373, "The Battle of Sector 001 occurs. A Starfleet Task Force engages in a running battle with a Borg cube en route to Earth. The USS Defiant NX-74205 is severely damaged, with the crew evacuated to the Enterprise. The USS Enterprise NCC-1701-E follows a Borg Sphere launched from the destroyed Borg Cube through a temporal rift. They are transported back to the year 2063, effectively altering history permanently." });

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 46,
                columns: new[] { "Date", "Description" },
                values: new object[] { 2375, "Data is transferred to observe the Ba'ku on a joint mission between the Federation and the Son'a. A sudden malfunction of Data jeopardizes the mission. The Enterprise discovers that the Ba'ku planet has effectively made the inhabitants immortal. The Son'a are seeking to exploit this to reverse their rapidly declining health and destroy the planet in the process." });

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 47,
                columns: new[] { "Date", "Description" },
                values: new object[] { 2379, "A previously unknown Android created by Dr. Soong named 'B-4' is discovered. This Android appears to be less advanced then Data and Lore. The Romulans have cloned Captain Picard and are planning an attack on Earth. The crew of the enterprise must stop this threat. Lt. Commander Data sacrifices his life to save Picard and the crew of the Enterprise. Data's memory chip is installed into B-4." });

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 48,
                columns: new[] { "Date", "Description" },
                values: new object[] { 2387, "A star in the Romulan Empire goes Supernova. Ambassador Spock attempts to counter the resulting shockwave using Red Matter, but is unable to save the planet Romulus from destruction." });

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 49,
                columns: new[] { "Date", "Description" },
                values: new object[] { 2395, "A retired Picard gets jumped through time. He is put through a continuation of the humanities trial conducted by the Q continuum. He investigates a spatial anomaly. His friends question his mental health." });

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 50,
                columns: new[] { "Date", "Description" },
                values: new object[] { 2399, "Mass produced androids go AWOL and attack the base on Mars. Jean Luc Picard comes out of retirement after finding out that Data's 'soul' may still be alive on the research planet of Dr. Maddox. Picard leads an unsanctioned mission to find this planet." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 8,
                column: "Bio",
                value: "Captain of the USS Enterprise C");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 9,
                column: "Bio",
                value: "Chief Engineer on the USS Enterprise C");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 10,
                column: "Bio",
                value: "Chief of Security on the USS Enterprise C");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 11,
                column: "Bio",
                value: "Commander on the USS Enterprise C");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 12,
                columns: new[] { "Bio", "Name" },
                values: new object[] { "Counselor on the USS Enterprise C", "Dianna Troi" });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 13,
                columns: new[] { "Bio", "Name" },
                values: new object[] { "Former Chief of Security on the USS Enterprise C", "Dana Yar" });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 14,
                column: "Bio",
                value: "Chief Medical Officer on the USS Enterprise C");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 15,
                column: "Bio",
                value: "Ensign aboard the USS Enterprise-C, training to become a Starfleet Officer.");

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 1,
                column: "Description",
                value: "The crew of the USS Enterprise return back to Earth after their voyage to save Spock, only to find that an alien life-form probing Earth. Earth is destroyed, forcing the crew to find a way to travel back in time to prevent Earth's destruction.");

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 2,
                column: "Description",
                value: "World War III starts on Earth. Eco-Terrorists attack the world. 37 Million people die.");

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 5,
                column: "Description",
                value: "Zefram Cochrane successful launches the first space craft using warp technology into space, The Pheonix. This craft is seen by a Vulcan ship passing by Earth's solar system. The Vulcans land on Earth to meet humanity and welcome them into and Zefram Cochrane is held in a high status. The events of this date are rewritten when the crew of the USS Enterprise C have to travel back in time to stop the Borg from destroying Earth and preventing the launch of the first craft. Captain Jean Luc Picard and his crew successfully thwart the Borg and help Zefram Cochrane launch his.");

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 8,
                column: "Description",
                value: "Star of the Earth and Ramulan War");

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 9,
                column: "Description",
                value: "Earth-Ramulan War comes to a close with the Battle of Cheron, which results in Earth inflicting a humiliating defeat to the Romulans. The Neutral Zone is then later established.");

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 11,
                column: "Description",
                value: "Sarek, Vulcan's future Ambassador and Spock's Father is born.");

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 15,
                column: "Description",
                value: "James T. Kirk and Nyota Uhura is born.");

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 17,
                column: "Description",
                value: "The USS Enterprise is refitted and renamed NCC-1701. It is launched on a second five-year mission under the command of Captain Christopher Pike.");

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 18,
                column: "Description",
                value: "James T Kirk is appointed to Captain of the USS Enterprise NCC-1701. Montgomery Scott 'Scotty' is appointed Chief Engineer. Leonard McCoy 'Bones' is appointed Chief Medical Officer. Hikaru Sulu is appointed Helmsman. Nyota Uhura is appointed Chief Communications Officer. Pavel Chekov is appointed First Officer. Spock is appointed Chief Science Officer. The Enterprise sets out on a 5 year mission to chart out planets, explore and discover new life forms.");

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 20,
                column: "Description",
                value: "Admiral Kirk and a new crew take off on a new 5 year voyage in the newly refitted Enterprise. An unknown life-form named V'ger is causing destruction in Klingon space and is approaching the Earth. Kirk leads a mission to investigate and hopefully stop this threat. The threat is avoided but at great cost.");

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 21,
                column: "Description",
                value: "The USS Enterprise UCC-1701 returns from it's voyage and is retired from active duty and is repurposed as a training vessel.");

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 22,
                column: "Description",
                value: "Admiral Kirk oversees a training exercise aboard the Enterprise NCC-1701. Kahn, an old enemy of Kirk and the crew of the Enterprise takes a science vessel captive to get revenge against the crew of the Enterprise. Spock dies to save the crew of the Enterprise. Upon returning home the Enterprise is marked for complete decommission. After learning that Spock's spirit is still alive, the crew steal the Enterprise to return to the planet where Spock's body was laid to rest in hopes of reviving him. The Enterprise is destroyed to prevent it from landing in enemy hands. The crew of the Enterprise steal a Klingon Warbird vessel.");

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 25,
                column: "Description",
                value: "The Klingon moon of Praxis is destroyed and the Klingon Empire decided to make peace with the Federation. A group of rebel Klingon who oppose this peace treaty, plan to attack the location of the peace treaty. Kirk under command of the Enterprise and Hikaru Sulu, newly appointed Captain of the USS Excelsior intervene and stop the attack. Admiral Kirk joins the newly built Enterprise NCC 1701-B and it's Captain, John Harriman, on a launching mission. The ship is struck by the Nexus and Kirk is lost, and presumed dead.");

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 26,
                column: "Description",
                value: "Jean-Luc Picard is born in LaBarre, France on Earth");

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 27,
                column: "Description",
                value: "The Tomed Incident was an alleged terrorist attack by extremist Romulan Admiral Aventeer Vokar and 5 crewmates. Their ship impacted with an asteroid base in the Foxtrot center and and its quantum singularity drive caused a massive explosion disrupting space-time throughout the sector and wiping out dozens of asteroid bases and at least one starship, the USS Agamemnon. Thousands of lives were said to be lost. This incident led to the Klingon Empire siding with Federation Forces and the retreat of the Imperial Fleet. Two months later the Treaty of Alegron is signed banning the development of cloaking weapons in the Federation in exchange for the Star Empire's agreement to withdraw behind its borders and to recall all of its diplomatic missions and citizens.");

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 28,
                column: "Description",
                value: "Beverly Howard (Crusher) is born in Copernicus City, Luna");

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 29,
                column: "Description",
                value: "Jean-Luc Picard graduates from Starfleet Academy on Earth");

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 31,
                columns: new[] { "Date", "Description" },
                values: new object[] { 2335, "Geordi La Forge is born in Mogadishu, Somalia. William T. Riker is born in Valdez, Alaska" });

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 32,
                columns: new[] { "Date", "Description" },
                values: new object[] { 2336, "Deanna Troi is born on Betazed." });

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 33,
                columns: new[] { "Date", "Description" },
                values: new object[] { 2337, "Tasha yar is born in a failed Federation colony on Turkana IV" });

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 34,
                columns: new[] { "Date", "Description" },
                values: new object[] { 2340, "Worf, son of Mogh, is born on the Kilingon homeworld, Qo'noS" });

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 35,
                columns: new[] { "Date", "Description" },
                values: new object[] { 2395, "Episode: All good things, TNG Series Finale, The future segment of the episode in which a retired Picard jumps through time as a continuation of humanities continuing trial by the Q continuum, to investigate a spatial anomaly while his friends question Picard's mental health" });

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 36,
                columns: new[] { "Date", "Description" },
                values: new object[] { 2387, "A star in the Romulan Empire goes Supernova. Ambassador Spock attempts to counter the resulting shockwave using Red Matter, but is unable to save the planet Romulus from destruction. Spock and the Romulan mining ship Narada, commanded by Nero, are dragged into a black hole created by the Red Matter detonation and arrive in the past. Nero's arrival in 2233 and subsequent attack on the USS Kelvin creates the Kelvin Timeline." });

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 37,
                columns: new[] { "Date", "Description" },
                values: new object[] { 2379, "The events of Star Trek: Nemesis, Discovery of previously unknown Android named 'B-4', a less advanced android designed by Dr.Soong and brother to LT. Commander Data. Lt. Commander Data sacrifices his Life to save Picard and the crew of the Enterprise" });

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 38,
                columns: new[] { "Date", "Description" },
                values: new object[] { 2375, "The events of Star Trek: Insurrection. Data is transferred to observe the Ba'ku on a joint mission between the Federation and the Son'a. While investigating a sudden malfunction of data that has jeopardized the safety of the observing task force, the Enterprise discovers that the Ba'ku planet has effectively made the inhabitants immortal, that the Son'a are seeking to exploit the resource to reverse their rapidly declining health and in doing so will destroy the planet in the process" });

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 39,
                columns: new[] { "Date", "Description" },
                values: new object[] { 2373, "The events of Star Trek: First Contact. The Battle of Sector 001 occurs with a Starfleet Task Force engaging in a running battle with a Borg cube en route to Earth. The USS Defiant (NX-74205) is severely damaged but not destroyed, with the crew evacuated to the Enterprise. The USS Enterprise (NCC-1701-E) follows a Borg sphere through a temporal rift and events shift at that point to 2063." });

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 40,
                columns: new[] { "Date", "Description" },
                values: new object[] { 2372, "Sovereign-class USS Enterprise (NCC-1701-E) is launched under the command of Captain Jean-Luc Picard." });

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 41,
                columns: new[] { "Date", "Description" },
                values: new object[] { 2371, "The events of Star Trek Generations. The USS Enterprise (NCC-1701-D)'s stardrive section is destroyed by a warp core breach; the saucer section containing the crew makes a forced landing on Veridian III. The ship is subsequently declared a total loss. James T. Kirk reappears from the temporal continuum in which he had been since his disappearance in 2293. Kirk is killed on Veridian III. (Kirk is resurrected a month later in a subsequent story written by William Shatner, called The Return.)" });

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 42,
                column: "Description",
                value: "The Borg assimilate Captain Jean-Luc Picard; the Battle of Wolf 359 is fought 7.7 light years from Earth in Sector 001. The battle results in the loss of 39 Starfleet vessels and over 11,000 lives. With the task force lost, the Borg continue to Earth. Picard is rescued and the Borg cube is destroyed via the actions of the crew of the Enterprise-D.");

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 43,
                columns: new[] { "Date", "Description" },
                values: new object[] { 2370, "The end of Star Trek: The Next Generation series." });

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 44,
                columns: new[] { "Date", "Description" },
                values: new object[] { 2370, "The beginning of Star Trek: The Next Generation. Jean-Luc Picard is appointed captain of the USS Enterprise(NCC-1701-D), William T. Riker is appointed first officer, Data is appointed second officer operations officer, Geordi La Forge is appointed helmsman and later chief engineer, Tasha Yar is appointed chief of security, Worf (son of Mogh) Rozhenko is appointed to chief of security after Yar's death, Beverly Crusher is appointed chief medical officer, Deanna Troi is appointed ship's, Wesley Crusher son of Beverley Crusher is later appointed to acting ensign." });

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 45,
                columns: new[] { "Date", "Description" },
                values: new object[] { 2363, "USS Enterprise (NCC-1701-D), the third Galaxy-class starship (following the Galaxy and Yamato) is launched from the Utopia Planitia shipyards in Mars orbit (under the command of Jean-Luc Picard), and becomes the Federation's new flagship." });

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 46,
                columns: new[] { "Date", "Description" },
                values: new object[] { 2364, "The Stargazer is later recovered in 2364." });

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 47,
                columns: new[] { "Date", "Description" },
                values: new object[] { 2357, "Worf is the first Klingon to enter Starfleet Academy." });

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 48,
                columns: new[] { "Date", "Description" },
                values: new object[] { 2355, "The USS Stargazer is attacked by an unknown vessel (later discovered to be Ferengi in origin) in the Maxia Zeta system. Jean-Luc Picard wins the confrontation by devising a tactic which becomes known as the Picard Manoeuvre. However, due to damage suffered during the battle, the crew are forced to abandon ship." });

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 49,
                columns: new[] { "Date", "Description" },
                values: new object[] { 2346, "Worf's parents are killed by Romulans in the Khitomer massacre. Worf (age 6) is adopted by human parents." });

            migrationBuilder.UpdateData(
                table: "TrekEvents",
                keyColumn: "TrekEventId",
                keyValue: 50,
                columns: new[] { "Date", "Description" },
                values: new object[] { 2334, "The Enterprise-C, under the command of Captain Rachel Garrett, is destroyed defending a Klingon settlement on Narendra III under attack from Romulans. Due to the Enterprise-C's sacrifice, a new era of more open communication begins between the Federation and the Klingon Empire, leading to a formalized alliance." });
        }
    }
}
