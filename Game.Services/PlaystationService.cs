﻿using Game.Data;
using Game.Models.Playstation;
using System;
using Game.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using Game.Data.Entities;

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
                var entity = context.PlaystationGames.Find(id);
                return entity;
            }
        }

        public IEnumerable<PlaystationGameListModel> GetPlaystationGames()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var entities = context.PlaystationGames.ToList();
                return entities;
            }
        }

        public void UpdatePlaystationGame(int id, PlaystationUpdateModel playstationGameToUpdate)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var entities = context.PlaystationGames.Find(id);
            }
        }
    }
}
