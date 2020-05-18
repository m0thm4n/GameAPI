using Game.Data;
using Game.Contracts;
using Game.Models.PC;
using System.Collections.Generic;
using System.Linq;

namespace Game.Services
{
    public class PCGameService : IPCService
    {
        public void CreatePCGame(PCCreateModel pcGameToCreate)
        {
            using (ApplicationDbContext ctx = new ApplicationDbContext())
            {
                ctx.PCGames.Add(new PCGame(pcGameToCreate));
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
                        Title = PCGame.Title,
                        Price = PCGame.Price,
                        Genre = PCGame.Genre,
                        MaturityRating = PCGame.MaturityRating,
                        Rating = PCGame.Rating,
                        Publisher = PCGame.Publisher,
                        Developer = PCGame.Developer
                    })
                .ToList();
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
                        Developer = entity.Developer,
                        Publisher = entity.Publisher
                    };
            }
        }

        public void UpdatePCGame(int id, PCUpdateModel pcGameToUpdate)
        {
            using (var ctx = new ApplicationDbContext())
            {
                PCGame pcGameWeWantToUpdate = ctx.PCGames.Find(pcGameToUpdate.Title);

                if (pcGameToUpdate != null)
                {
                    pcGameWeWantToUpdate.Title = pcGameToUpdate.Title;
                    pcGameWeWantToUpdate.Price = pcGameToUpdate.Price;
                    pcGameWeWantToUpdate.Genre = pcGameToUpdate.Genre;
                    pcGameWeWantToUpdate.MaturityRating = pcGameToUpdate.MaturityRating;
                    pcGameWeWantToUpdate.Rating = pcGameToUpdate.Rating;
                    pcGameWeWantToUpdate.Publisher = pcGameToUpdate.Publisher;
                    pcGameWeWantToUpdate.Developer = pcGameToUpdate.Developer;

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
