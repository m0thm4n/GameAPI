using Game.Data;
using Game.Contracts;
using Game.Models.PC;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Game.Services
{
    public class PCGameService : IPCService
    {
        public void CreatePCGame(PCCreateModel model)
        {
            var pcGameToCreate = new PCGame()
            {
                Title = model.Title,
                Price = model.Price,
                Genre = model.Genre,
                MaturityRating = model.MaturityRating,
                Rating = model.Rating,
                PublisherId = model.PublisherId,
                DeveloperId = model.DeveloperId
            };
            using (ApplicationDbContext ctx = new ApplicationDbContext())
            {
                ctx.PCGames.Add(pcGameToCreate);
                ctx.SaveChanges();
            }
        }

        public IEnumerable<PCListModel> GetPCGames()
        {
            using (var ctx = new ApplicationDbContext())
            {
                return ctx
                    .PCGames
                    .Select(PCGame => new PCListModel()
                    {
                        PCGameId = PCGame.PCGameId,
                        Title = PCGame.Title,
                        Price = PCGame.Price,
                        Genre = PCGame.Genre,
                        Publisher = PCGame.Publisher.Name,
                        Developer = PCGame.Developer.Name
                    })
                .ToArray();
            }
        }

        public PCListModel GetPCGame(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .PCGames
                    .Single(e => e.PCGameId == id);
                return
                    new PCListModel
                    {
                        PCGameId = entity.PCGameId,
                        Title = entity.Title,
                        Price = entity.Price,
                        Genre = entity.Genre,
                        MaturityRating = entity.MaturityRating,
                        Rating = entity.Rating,
                        Developer = entity.Developer.Name,
                        Publisher = entity.Publisher.Name
                    };
            }
        }

        public void UpdatePCGame(int id, PCUpdateModel pcGameToUpdate)
        {
            using (var ctx = new ApplicationDbContext())
            {
                PCGame pcGameWeWantToUpdate = ctx.PCGames.Single(x => x.PCGameId == pcGameToUpdate.PCGameId);

                if (pcGameToUpdate != null)
                {
                    pcGameWeWantToUpdate.Title = pcGameToUpdate.Title;
                    pcGameWeWantToUpdate.Price = pcGameToUpdate.Price;
                    pcGameWeWantToUpdate.Rating = pcGameToUpdate.Rating;

                    ctx.SaveChanges();
                }
            }
        }

        public void DeleteGame(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var pcGameToDelete =
                    ctx
                    .PCGames
                    .Single(e => e.PCGameId == id);

                ctx.PCGames.Remove(pcGameToDelete);

                ctx.SaveChanges();
            }
        }
    }
}
