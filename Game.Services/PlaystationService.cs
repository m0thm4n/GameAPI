using Game.Contracts;
using Game.Data;
using Game.Data.Entities;
using Game.Models.Playstation;
using System.Collections.Generic;
using System.Linq;

namespace Game.Services
{
    public class PlaystationService : IPlaystationService
    {
        public void CreateGame(PlaystationGameCreateModel playstaionGameToCreate)
        {
            var entity = new PlaystationGame()
            {
                PlaystationGameId = playstaionGameToCreate.PlaystationGameId,
                Title = playstaionGameToCreate.Title,
                Developer = playstaionGameToCreate.Developer,
                Publisher = playstaionGameToCreate.Publisher,
                Rating = playstaionGameToCreate.Rating,
                MaturityRating = playstaionGameToCreate.MaturityRating,
                Price = playstaionGameToCreate.Price
            };

            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                context.PlaystationGames.Add(entity);
                context.SaveChanges();
            }
        }

        public void DeleteGame(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var entity = context.PlaystationGames.Find(id);
                context.PlaystationGames.Remove(entity);
                context.SaveChanges();
            }
        }

        public PlaystationGameModel GetGame(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var entity = context.PlaystationGames.Find(id);
                return entity;
            }
        }

        public IEnumerable<PlaystationGameListModel> GetGames()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var entities = context.PlaystationGames.ToList();
                return entities;
            }
        }

        public void UpdateGame(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var entities = context.PlaystationGames.Find(id);
            }
        }
    }
}
