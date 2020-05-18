using Game.Contracts;
using Game.Data;
using Game.Data.Entities;
using Game.Models.Developer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Services
{
    public class DeveloperService : IDeveloperService
    {
        public void CreateDeveloper(DeveloperCreateModel developerToCreate)
        {
            var entity = new Developer()
            {
                DeveloperId = developerToCreate.DeveloperId,
                Name = developerToCreate.Name,
            };

            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                context.Developers.Add(entity);
                context.SaveChanges();
            }
        }

        public void DeleteDeveloper(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var entity = context.Developers.Find(id);
                context.Developers.Remove(entity);
                context.SaveChanges();
            }
        }

        public DeveloperDetailModel GetDeveloper(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var entity =
                    context
                    .Developers
                    .Single(e => e.DeveloperId == id);
                return
                    new DeveloperDetailModel
                    {
                        DeveloperId = entity.DeveloperId,
                        Name = entity.Name,
                    };
            }
        }

        public IEnumerable<DeveloperListModel> GetDevelopers()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context
                   .Developers
                   .Select(game => new DeveloperListModel()
                   {
                       DeveloperId = game.DeveloperId,
                       Name = game.Name,
                   })
               .ToArray();
            }
        }

        public void UpdateDeveloper(int id, DeveloperUpdateModel playstationGameToUpdate)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var entities = context.Developers.Find(id);
            }
        }
    }
}
