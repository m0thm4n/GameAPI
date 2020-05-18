using Game.Models.Publisher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Contracts
{
    public interface IPublisherContract
    {
        void CreatePublisher(PublisherCreateModel publisherToCreate);

        IEnumerable<PublisherListModel> GetPublisher();

        PublisherListModel GetPublisher(int id);

        void UpdatePublisher(int id, PublisherUpdateModel publisherToUpdate);

        void DeletePublisher(int id);
    }
}
