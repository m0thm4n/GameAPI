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

            //context.Developers.AddOrUpdate(x => x.DeveloperId,
            //    new Developer() { DeveloperId = 1, Name = "Arkane Studios" });

            //context.Publishers.AddOrUpdate(x => x.PublisherId,
            //    new Publisher() { PublisherId = 1, Name = "Bethesda Softworks" });

            //context.XboxGames.AddOrUpdate(x => x.XboxId,
            //    new XboxGame() { XboxId = 1, Name = "Prey", Genre = "First-Person Shooter", MaturityRating = "M",
            //        Rating = 4.5, Price = 16.99m, DeveloperId = 1, PublisherId = 1 });

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
