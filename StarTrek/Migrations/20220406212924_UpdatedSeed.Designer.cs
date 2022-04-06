﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StarTrek.Models;

namespace StarTrek.Solution.Migrations
{
    [DbContext(typeof(StarTrekContext))]
    [Migration("20220406212924_UpdatedSeed")]
    partial class UpdatedSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("StarTrek.Models.Character", b =>
                {
                    b.Property<int>("CharacterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bio")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Image")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("CharacterId");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            CharacterId = 1,
                            Bio = "Captain of the USS Enterprise NCC-1701",
                            Image = "https://cdn.discordapp.com/attachments/959946752771915856/961290789948895242/captain-kirk.jpg",
                            Name = "James T. Kirk"
                        },
                        new
                        {
                            CharacterId = 2,
                            Bio = "Helmsman on the USS Enterprise NCC-1701",
                            Image = "https://cdn.discordapp.com/attachments/959946752771915856/961290790510952478/Hikaru-Sulu-star-trek-the-movies-13224553-900-1330.jpg",
                            Name = "Hikaru Sulu"
                        },
                        new
                        {
                            CharacterId = 3,
                            Bio = "Chief Communications Officer on the USS Enterprise NCC-1701",
                            Image = "https://cdn.discordapp.com/attachments/959946752771915856/961290791479820308/Nyota-Uhura-star-trek-the-movies-13224660-580-901.jpg",
                            Name = "Nyota Uhura"
                        },
                        new
                        {
                            CharacterId = 4,
                            Bio = "Chief Science Officer on the USS Enterprise NCC-1701",
                            Image = "https://cdn.discordapp.com/attachments/959946752771915856/961290790888415322/Mr-Spock-star-trek-the-movies-13224893-800-1100.jpg",
                            Name = "Spock"
                        },
                        new
                        {
                            CharacterId = 5,
                            Bio = "Chief Medical Officer on the USS Enterprise NCC-1701",
                            Image = "https://cdn.discordapp.com/attachments/959946752771915856/961290790221516810/Dr-Leonard-McCoy-star-trek-the-movies-13224707-800-990.jpg",
                            Name = "Leonard McCoy"
                        },
                        new
                        {
                            CharacterId = 6,
                            Bio = "Chief Engineer on the USS Enterprise NCC-1701",
                            Image = "https://cdn.discordapp.com/attachments/959946752771915856/961299292981710879/montgomery-scott.png",
                            Name = "Montgomery Scott"
                        },
                        new
                        {
                            CharacterId = 7,
                            Bio = "First Officer on the USS Enterprise NCC-1701",
                            Image = "https://cdn.discordapp.com/attachments/959946752771915856/961290791173623818/Pavel-Chekov-star-trek-the-movies-13223605-580-901.jpg",
                            Name = "Pavel Chekov"
                        },
                        new
                        {
                            CharacterId = 8,
                            Bio = "Captain of the USS Enterprise NCC-1701-E",
                            Image = "https://cdn.discordapp.com/attachments/959946752771915856/961297643164799007/jean-luc-picard.png",
                            Name = "Jean Luc Picard"
                        },
                        new
                        {
                            CharacterId = 9,
                            Bio = "Chief Engineer on the USS Enterprise NCC-1701-E",
                            Image = "https://cdn.discordapp.com/attachments/959946752771915856/961297070139007046/41Td62h3vL._AC_.jpg",
                            Name = "Geordi LeForge"
                        },
                        new
                        {
                            CharacterId = 10,
                            Bio = "Chief of Security on the USS Enterprise NCC-1701-E",
                            Image = "https://cdn.discordapp.com/attachments/959946752771915856/961296578591727676/star-trek-worf-michael-dorn-1200x675.jpg",
                            Name = "Worf"
                        },
                        new
                        {
                            CharacterId = 11,
                            Bio = "Commander on the USS Enterprise NCC 1701-E",
                            Image = "https://cdn.discordapp.com/attachments/959946752771915856/961298256887959582/william-t-riker.png",
                            Name = "William Riker"
                        },
                        new
                        {
                            CharacterId = 12,
                            Bio = "Counselor on the USS Enterprise NCC-1701-E",
                            Image = "https://cdn.discordapp.com/attachments/959946752771915856/961298612795605032/dianna-troi.png",
                            Name = "Deanna Troi"
                        },
                        new
                        {
                            CharacterId = 13,
                            Bio = "Former Chief of Security on the USS Enterprise NCC-1701-E",
                            Image = "https://cdn.discordapp.com/attachments/959946752771915856/961295616061882408/unknown.png",
                            Name = "Natasha Yar"
                        },
                        new
                        {
                            CharacterId = 14,
                            Bio = "Chief Medical Officer on the USS Enterprise NCC-1701-E",
                            Image = "https://cdn.discordapp.com/attachments/959946752771915856/961295847574868069/unknown.png",
                            Name = "Beverly Crusher"
                        },
                        new
                        {
                            CharacterId = 15,
                            Bio = "Ensign aboard the USS Enterprise-NCC-1701-E, training to become a Starfleet Officer.",
                            Image = "https://cdn.discordapp.com/attachments/959946752771915856/961296050252054648/unknown.png",
                            Name = "Wesley Crusher"
                        },
                        new
                        {
                            CharacterId = 16,
                            Bio = "Inventor of the first Warp Drive.",
                            Image = "https://cdn.discordapp.com/attachments/959946752771915856/961295041601609840/unknown.png",
                            Name = "Zefram Cochrane"
                        },
                        new
                        {
                            CharacterId = 17,
                            Bio = "Member of the Q Continuum. Q is the reason the Borg now know about humanity.",
                            Image = "https://cdn.discordapp.com/attachments/959946752771915856/961291743582625802/unknown.png",
                            Name = "Q"
                        },
                        new
                        {
                            CharacterId = 18,
                            Bio = "Ambassador of Vulcan and father of Spock",
                            Image = "https://cdn.discordapp.com/attachments/959946752771915856/961294534761914458/unknown.png",
                            Name = "Sarek"
                        });
                });

            modelBuilder.Entity("StarTrek.Models.Starship", b =>
                {
                    b.Property<int>("StarshipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Captain")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Image")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Launch")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ShipClass")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ShipModel")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("StarshipId");

                    b.ToTable("Starships");

                    b.HasData(
                        new
                        {
                            StarshipId = 1,
                            Captain = "James T Kirk",
                            Image = "https://media.discordapp.net/attachments/959946752771915856/961313799321821194/unknown.png",
                            Launch = "2245",
                            ShipClass = "Constitution",
                            ShipModel = "USS Enterprise NCC-1701"
                        },
                        new
                        {
                            StarshipId = 2,
                            Captain = "James T Kirk",
                            Image = "https://media.discordapp.net/attachments/959946752771915856/961314079862034442/unknown.png",
                            Launch = "2286",
                            ShipClass = "Constitution",
                            ShipModel = "USS Enterprise NCC-1701-A"
                        },
                        new
                        {
                            StarshipId = 3,
                            Captain = "James T Kirk",
                            Image = "https://media.discordapp.net/attachments/959946752771915856/961314199563280464/unknown.png",
                            Launch = "2293",
                            ShipClass = "Excelsior",
                            ShipModel = "USS Enterprise NCC-1701-B"
                        },
                        new
                        {
                            StarshipId = 4,
                            Captain = "James T Kirk",
                            Image = "https://media.discordapp.net/attachments/959946752771915856/961314317066711040/unknown.png",
                            Launch = "2332",
                            ShipClass = "Ambassador",
                            ShipModel = "USS Enterprise NCC-1701-C"
                        },
                        new
                        {
                            StarshipId = 5,
                            Captain = "Jean Luc Picard",
                            Image = "https://media.discordapp.net/attachments/959946752771915856/961314925395980388/unknown.png?width=881&height=378",
                            Launch = "2363",
                            ShipClass = "Galaxy",
                            ShipModel = "USS Enterprise NCC-1701-D"
                        },
                        new
                        {
                            StarshipId = 6,
                            Captain = "Jean Luc Picard",
                            Image = "https://media.discordapp.net/attachments/959946752771915856/961314692226252850/unknown.png?width=881&height=315",
                            Launch = "2372",
                            ShipClass = "Sovereign",
                            ShipModel = "USS Enterprise NCC-1701-E"
                        });
                });

            modelBuilder.Entity("StarTrek.Models.TrekEvent", b =>
                {
                    b.Property<int>("TrekEventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Date")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("TrekEventId");

                    b.ToTable("TrekEvents");

                    b.HasData(
                        new
                        {
                            TrekEventId = 1,
                            Date = 1986,
                            Description = "The crew of the USS Enterprise return back to Earth after their voyage to save Spock. Only to find an alien life-form probing Earth. Earth is then destroyed by this entity. The crew are forced to find a way to travel back in time to prevent Earth's destruction."
                        },
                        new
                        {
                            TrekEventId = 2,
                            Date = 2026,
                            Description = "World War III starts on Earth. Eco-Terrorists attack the natons of the world. 37 Million people die."
                        },
                        new
                        {
                            TrekEventId = 3,
                            Date = 2032,
                            Description = "The creator of the warp drive: Zefram Cochrane, is born."
                        },
                        new
                        {
                            TrekEventId = 4,
                            Date = 2053,
                            Description = "World War III comes to an end. The world is in shambles after a long nuclear war. The aftermath of the war leaves a death rate of 600 Million people."
                        },
                        new
                        {
                            TrekEventId = 5,
                            Date = 2063,
                            Description = "Zefram Cochrane successfully launches the first spacecraft using warp technology into space, The Pheonix. A Vulcan ship passing by Earth's solar system sees this launch and lands on Earth to meet humanity. The events of this date are rewritten when the crew of the USS Enterprise E have to travel back in time to stop the Borg."
                        },
                        new
                        {
                            TrekEventId = 6,
                            Date = 2079,
                            Description = "Earth is finally recovering from the nuclear war."
                        },
                        new
                        {
                            TrekEventId = 7,
                            Date = 2119,
                            Description = "Zefram Cochrane sets off from his home on Alpha Centauri on an adventure. The world, never hearing back from him again presumes that he is dead."
                        },
                        new
                        {
                            TrekEventId = 8,
                            Date = 2156,
                            Description = "Start of the Earth and Ramulan War."
                        },
                        new
                        {
                            TrekEventId = 9,
                            Date = 2160,
                            Description = "The Earth-Ramulan War comes to a close with the Battle of Cheron. Earth inflicts a humiliating defeat to the Romulans. The Ramulan Neutral Zone is then later established."
                        },
                        new
                        {
                            TrekEventId = 10,
                            Date = 2161,
                            Description = "The United Federation of Planets is founded by Earth, Tellar, Vulcan and Andoria."
                        },
                        new
                        {
                            TrekEventId = 11,
                            Date = 2165,
                            Description = "Sarek, the father of Spock is born."
                        },
                        new
                        {
                            TrekEventId = 12,
                            Date = 2222,
                            Description = "Montgomery Scott is born."
                        },
                        new
                        {
                            TrekEventId = 13,
                            Date = 2227,
                            Description = "Leonard McCoy is born."
                        },
                        new
                        {
                            TrekEventId = 14,
                            Date = 2230,
                            Description = "Spock and Hikaru Sulu are born."
                        },
                        new
                        {
                            TrekEventId = 15,
                            Date = 2233,
                            Description = "James T. Kirk and Nyota Uhura are born."
                        },
                        new
                        {
                            TrekEventId = 16,
                            Date = 2245,
                            Description = "Pavel Chekov is born. The USS Enterprise, a Constitution class vessel is launched under the command of Robert April, on a five-year mission of exploration."
                        },
                        new
                        {
                            TrekEventId = 17,
                            Date = 2250,
                            Description = "The USS Enterprise is refitted and renamed to the USS Enterprise NCC-1701. It launches on a second five-year mission under the command of Captain Christopher Pike."
                        },
                        new
                        {
                            TrekEventId = 18,
                            Date = 2266,
                            Description = "James T Kirk is appointed to Captain of the USS Enterprise NCC-1701 and his crew are assigned: Montgomery Scott 'Scotty' appointed Chief Engineer. Leonard McCoy 'Bones' appointed Chief Medical Officer. Hikaru Sulu appointed Helmsman. Nyota Uhura appointed Chief Communications Officer. Pavel Chekov appointed First Officer. Spock, former crewmate under Christopher Pike is appointed Chief Science Officer. The Enterprise sets out on a 5 year mission to chart out planets, explore and discover new life forms."
                        },
                        new
                        {
                            TrekEventId = 19,
                            Date = 2270,
                            Description = "The USS Enterprise returns home from it's 5 year journey. Captain Kirk is promoted to Admiral and the Enterprise undergoes maintenance and refitting."
                        },
                        new
                        {
                            TrekEventId = 20,
                            Date = 2073,
                            Description = "Admiral Kirk and a new crew take off on a new 5 year voyage in the newly refitted Enterprise, under Captain . An unknown life-form named V'ger is causing destruction in Klingon space and is approaching the Earth. Kirk leads a mission to investigate and hopefully stop this threat. The threat is avoided but at great cost; Captain William Decker and Ship Navigator Ilia pass away in the line of duty."
                        },
                        new
                        {
                            TrekEventId = 21,
                            Date = 2279,
                            Description = "The USS Enterprise UCC-1701 returns from it's voyage and is retired from active duty. It is repurposed as a training vessel for new cadets."
                        },
                        new
                        {
                            TrekEventId = 22,
                            Date = 2285,
                            Description = "Admiral Kirk oversees a training exercise aboard the Enterprise NCC-1701. The crew receives a distress call from a research facility. It turns out Kahn, an old enemy of Captain Kirk and crew has taken a science vessel captive. Kahn is stopped, but Spock dies in attempt to save the crew of the Enterprise. On return home, the Enterprise is marked for permanent decommission. After learning that Spock's soul is still alive inside of Dr. McCoy, the crew steal the Enterprise against permission to return to the planet where Spock's body was left, to revive him. The Enterprise is destroyed to prevent it from landing in enemy hands. The crew of the Enterprise steal a Klingon Warbird vessel."
                        },
                        new
                        {
                            TrekEventId = 23,
                            Date = 2286,
                            Description = "The crew of the Enterprise returns home to find Earth getting destroyed. They travel back in time 100 years to try and prevent Earth's destruction. The newly refit USS Yorktown NCC-1717 is renamed the USS Enterprise NCC-1701-A and is launched on its maiden voyage with Admiral Kirk as it's Captain."
                        },
                        new
                        {
                            TrekEventId = 24,
                            Date = 2287,
                            Description = "A group of separatists take Federation Ambassadors of Earth, Klingon and Ramulas hostage on Nimbus III. Captain Kirk and the crew of the Enterprise is asked to intercept and save the hostages."
                        },
                        new
                        {
                            TrekEventId = 25,
                            Date = 2293,
                            Description = "The Klingon moon of Praxis is destroyed. The Klingon Empire decides to make peace with the Federation and a peace treaty ceremony is held. Opposing Klingon attack the location. The Enterprise NCC-1701-A intervene and stop the attack. Later, Admiral Kirk joins the newly built Enterprise NCC 1701-B and it's Captain, John Harriman, on a first launch ceremony. The during a routine inspection of the ship, it is struck by the Nexus and Kirk is lost, and presumed dead."
                        },
                        new
                        {
                            TrekEventId = 26,
                            Date = 2305,
                            Description = "Jean-Luc Picard is born."
                        },
                        new
                        {
                            TrekEventId = 27,
                            Date = 2311,
                            Description = "The Tomed Incident occurs. Alleged terrorists led by extremist Romulan Admiral Aventeer Vokar and 5 crewmates attack an asteroid base in the Foxtrot center. It's collision with the quantum singularity drive causes a massive explosion, disrupting space-time throughout the sector and wiping out dozens of asteroid bases. Thousands of lives were said to be lost. This incident leads to the Klingon Empire siding with the Federation and the retreat of the Imperial Fleet. Two months later the Treaty of Alegron is signed banning the development of cloaking weapons in the Federation in exchange for the Star Empire's agreement to withdraw behind its borders and to recall all of its diplomatic missions and citizens."
                        },
                        new
                        {
                            TrekEventId = 28,
                            Date = 2324,
                            Description = "Beverly Howard (married name: Crusher) is born."
                        },
                        new
                        {
                            TrekEventId = 29,
                            Date = 2327,
                            Description = "Jean-Luc Picard graduates from Starfleet Academy."
                        },
                        new
                        {
                            TrekEventId = 30,
                            Date = 2333,
                            Description = "Jean-Luc Picard becomes the Captain of the USS Stargazer."
                        },
                        new
                        {
                            TrekEventId = 31,
                            Date = 2334,
                            Description = "The Enterprise-C, under the command of Captain Rachel Garrett, is destroyed defending a Klingon settlement on Narendra III under attack from Romulans. Due to the Enterprise-C's sacrifice, a new era of more open communication begins between the Federation and the Klingon Empire, leading to a formalized alliance."
                        },
                        new
                        {
                            TrekEventId = 32,
                            Date = 2335,
                            Description = "Geordi La Forge and William T. Riker are born."
                        },
                        new
                        {
                            TrekEventId = 33,
                            Date = 2336,
                            Description = "Deanna Troi is born."
                        },
                        new
                        {
                            TrekEventId = 34,
                            Date = 2337,
                            Description = "Tasha Yar is born."
                        },
                        new
                        {
                            TrekEventId = 35,
                            Date = 2340,
                            Description = "Worf, son of Mogh, is born."
                        },
                        new
                        {
                            TrekEventId = 36,
                            Date = 2346,
                            Description = "Worf's biological parents are killed by Romulans in the Khitomer massacre. Worf at the age of 6 is adopted by a human couple."
                        },
                        new
                        {
                            TrekEventId = 37,
                            Date = 2355,
                            Description = "The USS Stargazer is attacked by an unknown vessel in the Maxia Zeta system. Jean-Luc Picard wins the confrontation by devising a tactic which becomes known as the Picard Manoeuvre. However, due to damage suffered during the battle, the crew are forced to abandon ship."
                        },
                        new
                        {
                            TrekEventId = 38,
                            Date = 2357,
                            Description = "Worf, joins the Starfleet Academy. He is the first Klingon in Star Fleet."
                        },
                        new
                        {
                            TrekEventId = 39,
                            Date = 2363,
                            Description = "USS Enterprise NCC-1701-D, the third Galaxy-class starship is launched from the Utopia Planitia shipyards and becomes the Federation's new flagship."
                        },
                        new
                        {
                            TrekEventId = 40,
                            Date = 2364,
                            Description = "The USS Enterprise NCC-1701-D is deployed on a 5 year mission with Jean-Luc Picard appointed as it's captain. William T. Riker is appointed Commander. Data is appointed his Operations Officer. Geordi La Forge is appointed Chief Engineer. Tasha Yar is appointed Chief of Security. Worf Rozhenko is appointed to Chief of Security on Tasha Yar's death. Beverly Crusher is appointed Chief Medical Officer. Deanna Troi is appointed Ship Counsellor. Wesley Crusher is later appointed to Acting Ensign."
                        },
                        new
                        {
                            TrekEventId = 41,
                            Date = 2365,
                            Description = "The Stargazer is recovered."
                        },
                        new
                        {
                            TrekEventId = 42,
                            Date = 2367,
                            Description = "The Borg invade the Enterprise and take Captain Jean Luc Picard hostage. He is assimilated into Lucutis of Borg. The battle results in the loss of 39 Starfleet vessels and over 11,000 lives. With the task force lost, the Borg continue to Earth. Picard is rescued and the Borg cube is destroyed via the actions of the crew of the USS Enterprise NCC-1701-D."
                        },
                        new
                        {
                            TrekEventId = 43,
                            Date = 2371,
                            Description = "Chasing after the Nexus to stop a terrorist seeking to use it's power to send time into a loop, the USS Enterprise NCC-1701-D's stardrive section is destroyed by a warp core breach. The saucer section containing the crew makes a forced landing on Veridian III. James T. Kirk, thought to be dead is found inside the temporal continuum of the Nexus. Jean Luc Picard and James T Kirk fight to stop the terrorist. Kirk is killed in action defending Jean Luc Picard."
                        },
                        new
                        {
                            TrekEventId = 44,
                            Date = 2372,
                            Description = "Sovereign-class USS Enterprise NCC-1701-E is launched under the command of Captain Jean-Luc Picard."
                        },
                        new
                        {
                            TrekEventId = 45,
                            Date = 2373,
                            Description = "The Battle of Sector 001 occurs. A Starfleet Task Force engages in a running battle with a Borg cube en route to Earth. The USS Defiant NX-74205 is severely damaged, with the crew evacuated to the Enterprise. The USS Enterprise NCC-1701-E follows a Borg Sphere launched from the destroyed Borg Cube through a temporal rift. They are transported back to the year 2063, effectively altering history permanently."
                        },
                        new
                        {
                            TrekEventId = 46,
                            Date = 2375,
                            Description = "Data is transferred to observe the Ba'ku on a joint mission between the Federation and the Son'a. A sudden malfunction of Data jeopardizes the mission. The Enterprise discovers that the Ba'ku planet has effectively made the inhabitants immortal. The Son'a are seeking to exploit this to reverse their rapidly declining health and destroy the planet in the process."
                        },
                        new
                        {
                            TrekEventId = 47,
                            Date = 2379,
                            Description = "A previously unknown Android created by Dr. Soong named 'B-4' is discovered. This Android appears to be less advanced then Data and Lore. The Romulans have cloned Captain Picard and are planning an attack on Earth. The crew of the enterprise must stop this threat. Lt. Commander Data sacrifices his life to save Picard and the crew of the Enterprise. Data's memory chip is installed into B-4."
                        },
                        new
                        {
                            TrekEventId = 48,
                            Date = 2387,
                            Description = "A star in the Romulan Empire goes Supernova. Ambassador Spock attempts to counter the resulting shockwave using Red Matter, but is unable to save the planet Romulus from destruction."
                        },
                        new
                        {
                            TrekEventId = 49,
                            Date = 2395,
                            Description = "A retired Picard gets jumped through time. He is put through a continuation of the humanities trial conducted by the Q continuum. He investigates a spatial anomaly. His friends question his mental health."
                        },
                        new
                        {
                            TrekEventId = 50,
                            Date = 2399,
                            Description = "Mass produced androids go AWOL and attack the base on Mars. Jean Luc Picard comes out of retirement after finding out that Data's 'soul' may still be alive on the research planet of Dr. Maddox. Picard leads an unsanctioned mission to find this planet."
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
