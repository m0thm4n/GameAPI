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
                new Developer() { DeveloperId = 22, Name = "Infinity Ward" });
            
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
                new Publisher() { PublisherId = 11, Name = "Bethesda Softworks" }
                );

            //XboxGamesToSeed
            context.XboxGames.AddOrUpdate(x => x.XboxId,
                new XboxGame()
                {
                    XboxId = 1,
                    Name = "Grand Theft Auto V",
                    Genre = "Action-adventure",
                    MaturityRating = "M",
                    Rating = 4.5,
                    Price = 16.99m,
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
                    Price = 16.99m,
                    DeveloperId = 15,
                    PublisherId = 8
                },
                new XboxGame()
                {
                    XboxId = 3,
                    Name = "Call of Duty: WWII",
                    Genre = "First-Person Shooter",
                    MaturityRating = "M",
                    Rating = 4.5,
                    Price = 16.99m,
                    DeveloperId = 16,
                    PublisherId = 8
                },
                new XboxGame()
                {
                    XboxId = 4,
                    Name = "Red Dead Redemption 2",
                    Genre = "First-Person Shooter",
                    MaturityRating = "M",
                    Rating = 4.5,
                    Price = 16.99m,
                    DeveloperId = 17,
                    PublisherId = 7
                },
                new XboxGame()
                {
                    XboxId = 5,
                    Name = "Minecraft",
                    Genre = "Sandbox",
                    MaturityRating = "M",
                    Rating = 4.5,
                    Price = 16.99m,
                    DeveloperId = 18,
                    PublisherId = 9
                },
                new XboxGame()
                {
                    XboxId = 6,
                    Name = "Call of Duty: Advanced Warfare",
                    Genre = "First-Person Shooter",
                    MaturityRating = "M",
                    Rating = 4.5,
                    Price = 16.99m,
                    DeveloperId = 16,
                    PublisherId = 8
                },
                new XboxGame()
                {
                    XboxId = 7,
                    Name = "Battlefield 1",
                    Genre = "First-Person Shooter",
                    MaturityRating = "M",
                    Rating = 4.5,
                    Price = 16.99m,
                    DeveloperId = 19,
                    PublisherId = 10
                },
                new XboxGame()
                {
                    XboxId = 8,
                    Name = "Fallout 4",
                    Genre = "Action-adventure",
                    MaturityRating = "M",
                    Rating = 4.5,
                    Price = 16.99m,
                    DeveloperId = 20,
                    PublisherId = 11
                },
                new XboxGame()
                {
                    XboxId = 9,
                    Name = "Halo 5: Guardians",
                    Genre = "First-Person Shooter",
                    MaturityRating = "M",
                    Rating = 4.5,
                    Price = 16.99m,
                    DeveloperId = 21,
                    PublisherId = 9
                },
                new XboxGame()
                {
                    XboxId = 10,
                    Name = "Call of Duty: Infinite Warfare",
                    Genre = "First-Person Shooter",
                    MaturityRating = "M",
                    Rating = 4.5,
                    Price = 16.99m,
                    DeveloperId = 22,
                    PublisherId = 8
                });

            //PCGamesToSeed -- PCGame entity needs adjusting to work with this model!
            //context.PCGames.AddOrUpdate(g => g.PCGameId,
            //    new PCGame()
            //    {
            //        PCGameId = 1,
            //        Title = "Prey",
            //        Genre = "First-Person Shooter",
            //        MaturityRating = "M",
            //        Rating = 4.5,
            //        Price = 16.99m,
            //        DeveloperId = 1,
            //        PublisherId = 1
            //    });

            //PlaystationGamesToSeed
            context.PlaystationGames.AddOrUpdate(p => p.PlaystationGameId,
                new PlaystationGame()
                {
                    PlaystationGameId = 1,
                    Title = "Uncharted 4: A Thief's End",
                    Genre = "Action-adventure",
                    MaturityRating = "M",
                    Rating = 4.5,
                    Price = 16.99m,
                    DeveloperId = 1,
                    PublisherId = 1
                },
                new PlaystationGame()
                {
                    PlaystationGameId = 2,
                    Title = "Marvel's Spider-Man",
                    Genre = "Action-adventure",
                    MaturityRating = "M",
                    Rating = 4.5,
                    Price = 16.99m,
                    DeveloperId = 2,
                    PublisherId = 1
                },
                new PlaystationGame()
                {
                    PlaystationGameId = 3,
                    Title = "The Witcher 3: Wild Hunt",
                    Genre = "Action RPG",
                    MaturityRating = "M",
                    Rating = 4.5,
                    Price = 16.99m,
                    DeveloperId = 3,
                    PublisherId = 2
                },
                new PlaystationGame()
                {
                    PlaystationGameId = 4,
                    Title = "God of War (2018)",
                    Genre = "Action-adventure",
                    MaturityRating = "M",
                    Rating = 4.5,
                    Price = 16.99m,
                    DeveloperId = 4,
                    PublisherId = 1
                },
                new PlaystationGame()
                {
                    PlaystationGameId = 5,
                    Title = "The Last of Us",
                    Genre = "Action-adventure, survival horror",
                    MaturityRating = "M",
                    Rating = 4.5,
                    Price = 16.99m,
                    DeveloperId = 1,
                    PublisherId = 1
                },
                new PlaystationGame()
                {
                    PlaystationGameId = 6,
                    Title = "Horizon Zero Dawn",
                    Genre = "Action RPG",
                    MaturityRating = "M",
                    Rating = 4.5,
                    Price = 16.99m,
                    DeveloperId = 5,
                    PublisherId = 1
                },
                new PlaystationGame()
                {
                    PlaystationGameId = 7,
                    Title = "Gran Turismo Sport",
                    Genre = "Racing",
                    MaturityRating = "M",
                    Rating = 4.5,
                    Price = 16.99m,
                    DeveloperId = 6,
                    PublisherId = 1
                },
                new PlaystationGame()
                {
                    PlaystationGameId = 8,
                    Title = "Monster Hunter: World",
                    Genre = "Action RPG",
                    MaturityRating = "M",
                    Rating = 4.5,
                    Price = 16.99m,
                    DeveloperId = 7,
                    PublisherId = 3
                },
                new PlaystationGame()
                {
                    PlaystationGameId = 9,
                    Title = "Final Fantasy VII Remake",
                    Genre = "Action RPG",
                    MaturityRating = "M",
                    Rating = 4.5,
                    Price = 16.99m,
                    DeveloperId = 8,
                    PublisherId = 12
                },
                new PlaystationGame()
                {
                    PlaystationGameId = 10,
                    Title = "Persona 5",
                    Genre = "Social simulation",
                    MaturityRating = "M",
                    Rating = 4.5,
                    Price = 16.99m,
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
                    MaturityRating = "M",
                    Rating = 4.5,
                    Price = 16.99m,
                    DeveloperId = 10,
                    PublisherId = 5
                },
                new SwitchGame()
                {
                    SwitchId = 2,
                    Name = "Super Smash Bros. Ultimate",
                    Genre = "Fighting",
                    MaturityRating = "M",
                    Rating = 4.5,
                    Price = 16.99m,
                    DeveloperId = 11,
                    PublisherId = 5
                },
                new SwitchGame()
                {
                    SwitchId = 3,
                    Name = "The Legend of Zelda: Breath of the Wild",
                    Genre = "Action-adventure",
                    MaturityRating = "M",
                    Rating = 4.5,
                    Price = 16.99m,
                    DeveloperId = 10,
                    PublisherId = 5
                },
                new SwitchGame()
                {
                    SwitchId = 4,
                    Name = "Super Mario Odyssey",
                    Genre = "Platformer",
                    MaturityRating = "M",
                    Rating = 4.5,
                    Price = 16.99m,
                    DeveloperId = 10,
                    PublisherId = 5
                },
                new SwitchGame()
                {
                    SwitchId = 5,
                    Name = "Pokemon Sword and Shield",
                    Genre = "Role-playing game",
                    MaturityRating = "M",
                    Rating = 4.5,
                    Price = 16.99m,
                    DeveloperId = 12,
                    PublisherId = 6
                },
                new SwitchGame()
                {
                    SwitchId = 6,
                    Name = "Animal Crossing: New Horizons",
                    Genre = "Social Simulation",
                    MaturityRating = "M",
                    Rating = 4.5,
                    Price = 16.99m,
                    DeveloperId = 10,
                    PublisherId = 5
                },
                new SwitchGame()
                {
                    SwitchId = 7,
                    Name = "Pokemon: Let's Go, Picachu!",
                    Genre = "Role-playing game",
                    MaturityRating = "M",
                    Rating = 4.5,
                    Price = 16.99m,
                    DeveloperId = 12,
                    PublisherId = 6
                },
                new SwitchGame()
                {
                    SwitchId = 8,
                    Name = "Splatoon 2",
                    Genre = "Third-Person Shooter",
                    MaturityRating = "M",
                    Rating = 4.5,
                    Price = 16.99m,
                    DeveloperId = 10,
                    PublisherId = 5
                },
                new SwitchGame()
                {
                    SwitchId = 9,
                    Name = "Super Mario Party",
                    Genre = "Party",
                    MaturityRating = "M",
                    Rating = 4.5,
                    Price = 16.99m,
                    DeveloperId = 13,
                    PublisherId = 5
                },
                new SwitchGame()
                {
                    SwitchId = 10,
                    Name = "New Super Mario Bros. U Deluxe",
                    Genre = "Platformer",
                    MaturityRating = "M",
                    Rating = 4.5,
                    Price = 16.99m,
                    DeveloperId = 10,
                    PublisherId = 5
                });

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
