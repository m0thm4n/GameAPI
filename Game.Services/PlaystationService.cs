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
        public void CreatePlaystationGame(PlaystationGameCreateModel playstaionGameToCreate)
        {
            var entity = new PlaystationGame()
            {
                PlaystationGameId = playstaionGameToCreate.PlaystationGameId,
                Title = playstaionGameToCreate.Title,
                Rating = playstaionGameToCreate.Rating,
                MaturityRating = playstaionGameToCreate.MaturityRating,
                Price = playstaionGameToCreate.Price,
                Genre = playstaionGameToCreate.Genre
            };

            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                context.PlaystationGames.Add(entity);
                context.SaveChanges();
            }
        }

        public void DeletePlaystationGame(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var entity = context.PlaystationGames.Find(id);
                context.PlaystationGames.Remove(entity);
                context.SaveChanges();
            }
        }

        public PlaystationGameModel GetPlaystationGame(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var entity =
                    context
                    .PlaystationGames
                    .Single(e => e.PlaystationGameId == id);
                return
                    new PlaystationGameModel
                    {
                        PlaystationGameId = entity.PlaystationGameId,
                        Title = entity.Title,
                        Genre = entity.Genre,
                        Rating = entity.Rating,
                        MaturityRating = entity.MaturityRating,
                        Price = entity.Price,
                        DeveloperName = entity.Developer.Name,
                        PublisherName = entity.Publisher.Name
                    };
            }
        }

        public IEnumerable<PlaystationGameListModel> GetPlaystationGames()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context
                   .PlaystationGames
                   .Select(game => new PlaystationGameListModel()
                   {
                       PlaystationGameId = game.PlaystationGameId,
                       Title = game.Title,
                       Genre = game.Genre,
                       Rating = game.Rating,
                       MaturityRating = game.MaturityRating,
                       Price = game.Price,
                       DeveloperName = game.Developer.Name,
                       PublisherName = game.Publisher.Name,
                   })
               .ToArray();
            }
        }

        public void UpdatePlaystationGame(int id, PlaystationUpdateModel playstationGameToUpdate)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var playstationGameWeWantToUpdate = context.PlaystationGames.Find(id);
                if (playstationGameToUpdate != null)
                {
                    playstationGameWeWantToUpdate.Title = playstationGameToUpdate.Title;
                    playstationGameWeWantToUpdate.Genre = playstationGameToUpdate.Genre;
                    playstationGameWeWantToUpdate.Rating = playstationGameToUpdate.Rating;
                    playstationGameWeWantToUpdate.MaturityRating = playstationGameToUpdate.MaturityRating;
                    playstationGameWeWantToUpdate.Price = playstationGameToUpdate.Price;

                    context.SaveChanges();
                }
            }
        }
    }
}
