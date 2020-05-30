using Game.API.Data;
using Game.Contracts;
using Game.Data;
using Game.Models.PC;
using System;
using System.Collections.Generic;
using System.Linq;
<<<<<<< Updated upstream
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
=======
using System.Security.Cryptography.X509Certificates;
>>>>>>> Stashed changes

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

        public List<PCListModel> GetPCList()
        {
            using (var ctx = new ApplicationDbContext())
            {
                return ctx
                    .PCGames
                    .Select(PCGame => new PCListModel()
<<<<<<< Updated upstream
                {
                     Title = PCGame.Title,
                     Price = PCGame.Price,
                     Genre = PCGame.Genre,
                     MaturityRating = PCGame.MaturityRating,
                     Rating = PCGame.Rating,
                     Publisher = PCGame.Publisher,
                     Developer = PCGame.Developer
                })
=======
                    {
                        PCGameId = PCGame.PCGameId,
                        Title = PCGame.Title,
                        Price = PCGame.Price,
                        Genre = PCGame.Genre,
<<<<<<< Updated upstream
                        MaturityRating = PCGame.MaturityRating,
                        Rating = PCGame.Rating,
                        Publisher = PCGame.PublisherId,
                        Developer = PCGame.DeveloperId
                    })
>>>>>>> Stashed changes
                .ToList();
=======
                        Publisher = PCGame.Publisher.Name,
                        Developer = PCGame.Developer.Name
                    })
                .ToArray();
>>>>>>> Stashed changes
            }
        }

        public void UpdatePCGame(PCUpdateModel pcGameToUpdate)
        {
            using (var ctx = new ApplicationDbContext())
            {
                PCGame pcGameWeWantToUpdate = ctx.PCGames.Single(x => x.PCGameId == pcGameToUpdate.PCGameId);

                if (pcGameToUpdate != null)
                {
                    pcGameWeWantToUpdate.Title = pcGameToUpdate.Title;
                    pcGameWeWantToUpdate.Price = pcGameToUpdate.Price;
                    pcGameWeWantToUpdate.Rating = pcGameToUpdate.Rating;
<<<<<<< Updated upstream
                    pcGameWeWantToUpdate.PublisherId = pcGameToUpdate.Publisher;
                    pcGameWeWantToUpdate.DeveloperId = pcGameToUpdate.Developer;
=======
>>>>>>> Stashed changes

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
