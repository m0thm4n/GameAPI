using Game.API.Models;
using Game.Contracts;
using Game.Data.Entites.PlaystationGame;
using Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;

namespace Game.Services
{
    class PlaystationService : IPlaystationGameService
    {
        public void CreateGame(PlaystationGameCreateModel playstaionGameToCreate)
        {
            var entity = new PlaystationGame()
            {
                PlaystationGameId = playstaionGameToCreate.PlaystationGameId,
                Name = playstaionGameToCreate.Name,
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

        public PlaystationGameItem GetGame(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var entity = context.PlaystationGames.Find(id);
                return entity;
            }
        }

        public IEnumerable<PlaystationGameItemList> GetGames()
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
