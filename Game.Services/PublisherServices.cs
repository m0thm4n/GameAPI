using Game.Contracts;
using Game.Data;
using Game.Data.Entities;
using Game.Models.Publisher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Services
{
    public class PublisherServices : IPublisherContract
    {
        // Create Publisher
        public void CreatePublisher(PublisherCreateModel publisher)
        {
            var publisherToCreate = new Publisher()
            {
                Name = publisher.Name,
            };
            using (ApplicationDbContext ctx = new ApplicationDbContext())
            {
                ctx.Publisher.Add(publisherToCreate);
                ctx.SaveChanges();
            }
        }

        // Delete Publisher
        public void DeletePublisher(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var publisherToDelete =
                    ctx
                    .Publisher
                    .Single(e => e.PublisherId == id);

                ctx.Publisher.Remove(publisherToDelete);

                ctx.SaveChanges();
            }
        }

        // List All Publishers
        public IEnumerable<PublisherListModel> GetPublisher()
        {
            using (var ctx = new ApplicationDbContext())
            {
                return ctx
                    .Publisher
                    .Select(p => new PublisherListModel()
                    {
                        PublisherId = p.PublisherId,
                        Name = p.Name
                    })
                .ToArray();
            }
        }

        // List Publisher
        public PublisherListModel GetPublisher(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Publisher
                    .Single(e => e.PublisherId == id);
                return
                    new PublisherListModel
                    {
                        PublisherId = entity.PublisherId,
                        Name = entity.Name
                    };
            }
        }

        // Update Publisher
        public void UpdatePublisher(int id, PublisherUpdateModel publisherToUpdate)
        {
            using (var ctx = new ApplicationDbContext())
            {
                Publisher publisherWeWantToUpdate = ctx.Publisher.Find(publisherToUpdate.Name);

                if(publisherToUpdate != null)
                {
                    publisherWeWantToUpdate.Name = publisherToUpdate.Name;

                    ctx.SaveChanges();
                }
            }
        }
    }
}
