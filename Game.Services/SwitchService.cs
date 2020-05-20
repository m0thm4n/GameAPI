using Game.Contracts;
using Game.Data;
using Game.Data.Entities;
using Game.Models.Switch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Services
{
    public class SwitchService : ISwitchService
    {
        public void CreateSwitchGame(SwitchCreateModel model)
        {
            var switchToCreate = new SwitchGame()
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
                ctx.SwitchGames.Add(switchToCreate);
                ctx.SaveChanges();
            }
        }

        public void DeleteSwitchGame(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var switchToDelete =
                    ctx
                    .SwitchGames
                    .Single(e => e.SwitchId == id);

                ctx.SwitchGames.Remove(switchToDelete);

                ctx.SaveChanges();
            }
        }

        public IEnumerable<SwitchGetAllModel> GetAllSwitchGames()
        {
            using (var ctx = new ApplicationDbContext())
            {
                return ctx
                    .SwitchGames
                    .Select(s => new SwitchGetAllModel()
                    {
                        SwitchId = s.SwitchId,
                        Name = s.Name,
                        Price = s.Price,
                        Genre = s.Genre,
                        DeveloperName = s.Developer.Name
                    })
                .ToArray();
            }
        }

        public SwitchDetailsModel GetSwitchGame(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .SwitchGames
                    .Single(e => e.SwitchId == id);
                return
                    new SwitchDetailsModel
                    {
                        SwitchId = entity.SwitchId,
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

        public void UpdateSwitchGame(int id, SwitchUpdateModel switchToUpdate)
        {
            using (var ctx = new ApplicationDbContext())
            {
                SwitchGame switchWeWantToUpdate = ctx.SwitchGames.Find(switchToUpdate.Name);

                if (switchToUpdate != null)
                {
                    switchWeWantToUpdate.Name = switchToUpdate.Name;
                    switchWeWantToUpdate.Price = switchToUpdate.Price;
                    switchWeWantToUpdate.Rating = switchToUpdate.Rating;

                    ctx.SaveChanges();
                }
            }
        }
    }
}
