using Game.Data;
using Game.Contracts;
using Game.Data;
using Game.Models.PC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

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

        public List<PCListModel> GetPCList()
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

        public void UpdatePCGame(PCUpdateModel pcGameToUpdate)
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

        public void DeleteGame(PCDeleteModel pcGameToDelete)
        {
            using (ApplicationDbContext ctx = new ApplicationDbContext())
            {
                ctx.PCGames.Remove(new PCGame(pcGameToDelete));
                ctx.SaveChanges();
            }
        }
    }
}
