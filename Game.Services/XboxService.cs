using Game.Contracts;
using Game.Data;
using Game.Data.Entities;
using Game.Models.Xbox;
using System.Collections.Generic;
using System.Linq;

namespace Game.Services
{
    public class XboxService : IXboxService
    {

        public void CreateXboxGame(XboxCreateModel model)
        {
            var xboxToCreate = new XboxGame()
            {
                Name = model.Name,
                Price = model.Price,
                Genre = model.Genre,
                MaturityRating = model.MaturityRating,
                Rating = model.Rating,
                DeveloperId = model.DeveloperId,
                PublisherId = model.PublisherId
            };
            using (ApplicationDbContext ctx = new ApplicationDbContext())
            {
                ctx.XboxGames.Add(xboxToCreate);
                ctx.SaveChanges();
            }
        }

        public void DeleteXboxGame(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var xboxToDelete =
                    ctx
                    .XboxGames
                    .Single(e => e.XboxId == id);

                ctx.XboxGames.Remove(xboxToDelete);

                ctx.SaveChanges();
            }
        }

        public IEnumerable<XboxGetAllGamesModel> GetAllXboxGames()
        {
            using (var ctx = new ApplicationDbContext())
            {
                return ctx
                    .XboxGames
                    .Select(x => new XboxGetAllGamesModel()
                    {
                        XboxId = x.XboxId,
                        Name = x.Name,
                        Price = x.Price,
                        Genre = x.Genre,
                        DeveloperName = x.Developer.Name
                    })
                .ToArray();
            }
        }

        public XboxDetailsModel GetXboxGame(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .XboxGames
                    .Single(e => e.XboxId == id);
                return
                    new XboxDetailsModel
                    {
                        XboxId = entity.XboxId,
                        Name = entity.Name,
                        Price = entity.Price,
                        Genre = entity.Genre,
                        MaturityRating = entity.MaturityRating,
                        Rating = entity.Rating,
                        DeveloperName = entity.Developer.Name,
                        PublisherName = entity.Publisher.Name
                    };
            }
        }

        public void UpdateXboxGame(XboxUpdatesModel xboxToUpdate)
        {
            using (var ctx = new ApplicationDbContext())
            {
                XboxGame xboxWeWantToUpdate = ctx.XboxGames.Find(xboxToUpdate.Name);

                if (xboxToUpdate != null)
                {
                    xboxWeWantToUpdate.Name = xboxToUpdate.Name;
                    xboxWeWantToUpdate.Price = xboxToUpdate.Price;
                    xboxWeWantToUpdate.Rating = xboxToUpdate.Rating;

                    ctx.SaveChanges();
                }
            }
        }
    }
}
