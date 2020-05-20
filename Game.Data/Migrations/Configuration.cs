namespace Game.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Game.Data.Entities;
    using Game.Models;


    internal sealed class Configuration : DbMigrationsConfiguration<Game.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Game.Data.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            // DevelopersToSeed
            context.Developers.AddOrUpdate(x => x.DeveloperId,
                new Developer() { DeveloperId = 1, Name = "Naughty Dog" },
                new Developer() { DeveloperId = 2, Name = "Insomniac Games" },
                new Developer() { DeveloperId = 3, Name = "CD Projekt Red" },
                new Developer() { DeveloperId = 4, Name = "Santa Monica Studio" },
                new Developer() { DeveloperId = 5, Name = "Guerrilla Games" },
                new Developer() { DeveloperId = 6, Name = "Polyphony Digital" },
                new Developer() { DeveloperId = 7, Name = "Capcom" },
                new Developer() { DeveloperId = 8, Name = "Square Enix" },
                new Developer() { DeveloperId = 9, Name = "P-Studio" },
                new Developer() { DeveloperId = 10, Name = "Nintendo EPD" },
                new Developer() { DeveloperId = 11, Name = "Bandai Namco Studios" },
                new Developer() { DeveloperId = 12, Name = "Game Freak" },
                new Developer() { DeveloperId = 13, Name = "ND Cube" },
                new Developer() { DeveloperId = 14, Name = "Rockstar North" },
                new Developer() { DeveloperId = 15, Name = "Treyarch" },
                new Developer() { DeveloperId = 16, Name = "Sledgehammer Games" },
                new Developer() { DeveloperId = 17, Name = "Rockstar Studios" },
                new Developer() { DeveloperId = 18, Name = "Mojang Studios" },
                new Developer() { DeveloperId = 19, Name = "EA DICE" },
                new Developer() { DeveloperId = 20, Name = "Bethesda Game Studios" },
                new Developer() { DeveloperId = 21, Name = "343 Industries" },
                new Developer() { DeveloperId = 22, Name = "Infinity Ward" },
                new Developer() { DeveloperId = 23, Name = "PUBG Corporation" },
                new Developer() { DeveloperId = 24, Name = "Blizzard Entertainment" },
                new Developer() { DeveloperId = 25, Name = "Re-Logic" },
                new Developer() { DeveloperId = 26, Name = "Maxis" },
                new Developer() { DeveloperId = 27, Name = "Facepunch Studios" },
                new Developer() { DeveloperId = 28, Name = "Frontier Developments" },
                new Developer() { DeveloperId = 29, Name = "Valve Software" });
            
            //PublishersToSeed
            context.Publishers.AddOrUpdate(x => x.PublisherId,
                new Publisher() { PublisherId = 1, Name = "Sony Interactive Entertainment" },
                new Publisher() { PublisherId = 2, Name = "CD Projekt SA" },
                new Publisher() { PublisherId = 3, Name = "Capcom" },
                new Publisher() { PublisherId = 4, Name = "Atlus" },
                new Publisher() { PublisherId = 5, Name = "Nintendo" },
                new Publisher() { PublisherId = 6, Name = "The Pokemon Company" },
                new Publisher() { PublisherId = 7, Name = "Rockstar Games" },
                new Publisher() { PublisherId = 8, Name = "Activision" },
                new Publisher() { PublisherId = 9, Name = "Microsoft Studios" },
                new Publisher() { PublisherId = 10, Name = "Electronic Arts" },
                new Publisher() { PublisherId = 11, Name = "Bethesda Softworks" },
                new Publisher() { PublisherId = 12, Name = "Square Enix" },
                new Publisher() { PublisherId = 13, Name = "PUBG Corporation" },
                new Publisher() { PublisherId = 14, Name = "Blizzard Entertainment" },
                new Publisher() { PublisherId = 15, Name = "Re-Logic" },
                new Publisher() { PublisherId = 16, Name = "Facepunch Studios" },
                new Publisher() { PublisherId = 17, Name = "Atari, Inc." },
                new Publisher() { PublisherId = 18, Name = "Valve Software" });

            //XboxGamesToSeed
            context.XboxGames.AddOrUpdate(x => x.XboxId,
                new XboxGame()
                {
                    XboxId = 1,
                    Name = "Grand Theft Auto V",
                    Genre = "Action-adventure",
                    MaturityRating = "M",
                    Rating = 7.8,
                    Price = 29.99m,
                    DeveloperId = 14,
                    PublisherId = 7
                },
                new XboxGame()
                {
                    XboxId = 2,
                    Name = "Call of Duty: Black Ops III",
                    Genre = "First-Person Shooter",
                    MaturityRating = "M",
                    Rating = 4.5,
                    Price = 32.80m,
                    DeveloperId = 15,
                    PublisherId = 8
                },
                new XboxGame()
                {
                    XboxId = 3,
                    Name = "Call of Duty: WWII",
                    Genre = "First-Person Shooter",
                    MaturityRating = "M",
                    Rating = 4.2,
                    Price = 37.88m,
                    DeveloperId = 16,
                    PublisherId = 8
                },
                new XboxGame()
                {
                    XboxId = 4,
                    Name = "Red Dead Redemption 2",
                    Genre = "First-Person Shooter",
                    MaturityRating = "M",
                    Rating = 7.7,
                    Price = 43.45m,
                    DeveloperId = 17,
                    PublisherId = 7
                },
                new XboxGame()
                {
                    XboxId = 5,
                    Name = "Minecraft: Xbox One Edition",
                    Genre = "Sandbox",
                    MaturityRating = "E 10+",
                    Rating = 6.8,
                    Price = 62.47m,
                    DeveloperId = 18,
                    PublisherId = 9
                },
                new XboxGame()
                {
                    XboxId = 6,
                    Name = "Call of Duty: Advanced Warfare",
                    Genre = "First-Person Shooter",
                    MaturityRating = "M",
                    Rating = 5.5,
                    Price = 19.99m,
                    DeveloperId = 16,
                    PublisherId = 8
                },
                new XboxGame()
                {
                    XboxId = 7,
                    Name = "Battlefield 1",
                    Genre = "First-Person Shooter",
                    MaturityRating = "M",
                    Rating = 7.6,
                    Price = 19.99m,
                    DeveloperId = 19,
                    PublisherId = 10
                },
                new XboxGame()
                {
                    XboxId = 8,
                    Name = "Fallout 4",
                    Genre = "Action-adventure",
                    MaturityRating = "M",
                    Rating = 6.5,
                    Price = 19.89m,
                    DeveloperId = 20,
                    PublisherId = 11
                },
                new XboxGame()
                {
                    XboxId = 9,
                    Name = "Halo 5: Guardians",
                    Genre = "First-Person Shooter",
                    MaturityRating = "T",
                    Rating = 6.4,
                    Price = 14.59m,
                    DeveloperId = 21,
                    PublisherId = 9
                },
                new XboxGame()
                {
                    XboxId = 10,
                    Name = "Call of Duty: Infinite Warfare",
                    Genre = "First-Person Shooter",
                    MaturityRating = "M",
                    Rating = 3.7,
                    Price = 14.99m,
                    DeveloperId = 22,
                    PublisherId = 8
                });

            //PCGamesToSeed -- PCGame entity needs adjusting to work with this model!
            context.PCGames.AddOrUpdate(g => g.PCGameId,
                new PCGame()
                {
                    PCGameId = 1,
                    Title = "PlayerUnknown's Battlegrounds",
                    Genre = "First-person shooter, Battle royale",
                    MaturityRating = "T",
                    Rating = 4.7,
                    Price = 29.99m,
                    DeveloperId = 23,
                    PublisherId = 13
                },
                new PCGame()
                {
                    PCGameId = 2,
                    Title = "Minecraft",
                    Genre = "Sandbox, survival",
                    MaturityRating = "E 10+",
                    Rating = 7.7,
                    Price = 26.99m,
                    DeveloperId = 18,
                    PublisherId = 9
                },
                new PCGame()
                {
                    PCGameId = 3,
                    Title = "Diablo III",
                    Genre = "Action RPG",
                    MaturityRating = "M",
                    Rating = 4.1,
                    Price = 19.99m,
                    DeveloperId = 24,
                    PublisherId = 14
                },
                new PCGame()
                {
                    PCGameId = 4,
                    Title = "World of Warcraft",
                    Genre = "MMORPG",
                    MaturityRating = "T",
                    Rating = 7.4,
                    Price = 37.99m,
                    DeveloperId = 24,
                    PublisherId = 14
                },
                new PCGame()
                {
                    PCGameId = 5,
                    Title = "Terraria",
                    Genre = "Action-adventure",
                    MaturityRating = "T",
                    Rating = 8.7,
                    Price = 19.99m,
                    DeveloperId = 25,
                    PublisherId = 15
                },
                new PCGame()
                {
                    PCGameId = 6,
                    Title = "The Sims",
                    Genre = "Life Simulation",
                    MaturityRating = "T",
                    Rating = 7.9,
                    Price = 44.59m,
                    DeveloperId = 26,
                    PublisherId = 8
                },
                new PCGame()
                {
                    PCGameId = 7,
                    Title = "Starcraft",
                    Genre = "Real-time strategy",
                    MaturityRating = "T",
                    Rating = 9.1,
                    Price = 25.90m,
                    DeveloperId = 24,
                    PublisherId = 14
                },
                new PCGame()
                {
                    PCGameId = 8,
                    Title = "GMod (Garry's Mod)",
                    Genre = "Sandbox",
                    MaturityRating = "N/A",
                    Rating = 9.0,
                    Price = 9.99m,
                    DeveloperId = 27,
                    PublisherId = 16
                },
                new PCGame()
                {
                    PCGameId = 9,
                    Title = "RollerCoaster Tycoon 3",
                    Genre = "Construction and management simulation",
                    MaturityRating = "E",
                    Rating = 5.2,
                    Price = 29.99m,
                    DeveloperId = 28,
                    PublisherId = 17
                },
                new PCGame()
                {
                    PCGameId = 10,
                    Title = "Half-Life 2",
                    Genre = "First-Person shooter",
                    MaturityRating = "M",
                    Rating = 9.1,
                    Price = 9.99m,
                    DeveloperId = 29,
                    PublisherId = 18
                });

            //PlaystationGamesToSeed
            context.PlaystationGames.AddOrUpdate(p => p.PlaystationGameId,
                new PlaystationGame()
                {
                    PlaystationGameId = 1,
                    Title = "Uncharted 4: A Thief's End",
                    Genre = "Action-adventure",
                    MaturityRating = "T",
                    Rating = 8.4,
                    Price = 17.99m,
                    DeveloperId = 1,
                    PublisherId = 1
                },
                new PlaystationGame()
                {
                    PlaystationGameId = 2,
                    Title = "Marvel's Spider-Man",
                    Genre = "Action-adventure",
                    MaturityRating = "T",
                    Rating = 8.6,
                    Price = 39.99m,
                    DeveloperId = 2,
                    PublisherId = 1
                },
                new PlaystationGame()
                {
                    PlaystationGameId = 3,
                    Title = "The Witcher 3: Wild Hunt",
                    Genre = "Action RPG",
                    MaturityRating = "M",
                    Rating = 9.2,
                    Price = 19.99m,
                    DeveloperId = 3,
                    PublisherId = 2
                },
                new PlaystationGame()
                {
                    PlaystationGameId = 4,
                    Title = "God of War (2018)",
                    Genre = "Action-adventure",
                    MaturityRating = "M",
                    Rating = 9.1,
                    Price = 16.99m,
                    DeveloperId = 4,
                    PublisherId = 1
                },
                new PlaystationGame()
                {
                    PlaystationGameId = 5,
                    Title = "The Last of Us Remastered",
                    Genre = "Action-adventure, survival horror",
                    MaturityRating = "M",
                    Rating = 9.1,
                    Price = 22.88m,
                    DeveloperId = 1,
                    PublisherId = 1
                },
                new PlaystationGame()
                {
                    PlaystationGameId = 6,
                    Title = "Horizon Zero Dawn",
                    Genre = "Action RPG",
                    MaturityRating = "T",
                    Rating = 8.4,
                    Price = 19.99m,
                    DeveloperId = 5,
                    PublisherId = 1
                },
                new PlaystationGame()
                {
                    PlaystationGameId = 7,
                    Title = "Gran Turismo Sport",
                    Genre = "Racing",
                    MaturityRating = "E",
                    Rating = 6.0,
                    Price = 20.75m,
                    DeveloperId = 6,
                    PublisherId = 1
                },
                new PlaystationGame()
                {
                    PlaystationGameId = 8,
                    Title = "Monster Hunter: World",
                    Genre = "Action RPG",
                    MaturityRating = "T",
                    Rating = 7.6,
                    Price = 29.99m,
                    DeveloperId = 7,
                    PublisherId = 3
                },
                new PlaystationGame()
                {
                    PlaystationGameId = 9,
                    Title = "Final Fantasy VII Remake",
                    Genre = "Action RPG",
                    MaturityRating = "T",
                    Rating = 8.0,
                    Price = 59.85m,
                    DeveloperId = 8,
                    PublisherId = 12
                },
                new PlaystationGame()
                {
                    PlaystationGameId = 10,
                    Title = "Persona 5",
                    Genre = "Social simulation",
                    MaturityRating = "M",
                    Rating = 8.7,
                    Price = 14.84m,
                    DeveloperId = 9,
                    PublisherId = 4
                });

            //SwitchGamesToSeed
            context.SwitchGames.AddOrUpdate(s => s.SwitchId,
                new SwitchGame()
                {
                    SwitchId = 1,
                    Name = "Mario Kart 8 Deluxe",
                    Genre = "Kart Racing",
                    MaturityRating = "E",
                    Rating = 8.6,
                    Price = 54.99m,
                    DeveloperId = 10,
                    PublisherId = 5
                },
                new SwitchGame()
                {
                    SwitchId = 2,
                    Name = "Super Smash Bros. Ultimate",
                    Genre = "Fighting",
                    MaturityRating = "E 10+",
                    Rating = 8.7,
                    Price = 59.99m,
                    DeveloperId = 11,
                    PublisherId = 5
                },
                new SwitchGame()
                {
                    SwitchId = 3,
                    Name = "The Legend of Zelda: Breath of the Wild",
                    Genre = "Action-adventure",
                    MaturityRating = "E 10+",
                    Rating = 8.6,
                    Price = 59.99m,
                    DeveloperId = 10,
                    PublisherId = 5
                },
                new SwitchGame()
                {
                    SwitchId = 4,
                    Name = "Super Mario Odyssey",
                    Genre = "Platformer",
                    MaturityRating = "E 10+",
                    Rating = 8.9,
                    Price = 54.98m,
                    DeveloperId = 10,
                    PublisherId = 5
                },
                new SwitchGame()
                {
                    SwitchId = 5,
                    Name = "Pokemon Sword and Shield",
                    Genre = "Role-playing game",
                    MaturityRating = "E",
                    Rating = 8.0,
                    Price = 59.99m,
                    DeveloperId = 12,
                    PublisherId = 6
                },
                new SwitchGame()
                {
                    SwitchId = 6,
                    Name = "Animal Crossing: New Horizons",
                    Genre = "Social Simulation",
                    MaturityRating = "E",
                    Rating = 5.2,
                    Price = 59.99m,
                    DeveloperId = 10,
                    PublisherId = 5
                },
                new SwitchGame()
                {
                    SwitchId = 7,
                    Name = "Pokemon: Let's Go, Pikachu!",
                    Genre = "Role-playing game",
                    MaturityRating = "E",
                    Rating = 6.1,
                    Price = 65.22m,
                    DeveloperId = 12,
                    PublisherId = 6
                },
                new SwitchGame()
                {
                    SwitchId = 8,
                    Name = "Splatoon 2",
                    Genre = "Third-Person Shooter",
                    MaturityRating = "E 10+",
                    Rating = 8.5,
                    Price = 59.95m,
                    DeveloperId = 10,
                    PublisherId = 5
                },
                new SwitchGame()
                {
                    SwitchId = 9,
                    Name = "Super Mario Party",
                    Genre = "Party",
                    MaturityRating = "E",
                    Rating = 7.3,
                    Price = 54.55m,
                    DeveloperId = 13,
                    PublisherId = 5
                },
                new SwitchGame()
                {
                    SwitchId = 10,
                    Name = "New Super Mario Bros. U Deluxe",
                    Genre = "Platformer",
                    MaturityRating = "E",
                    Rating = 7.0,
                    Price = 54.98m,
                    DeveloperId = 10,
                    PublisherId = 5
                });

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
