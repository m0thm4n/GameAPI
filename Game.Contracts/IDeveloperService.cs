using Game.Models.Developer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Contracts
{
    public interface IDeveloperService
    {
        void CreateDeveloper(DeveloperCreateModel developerToCreate);
        IEnumerable<DeveloperListModel> GetDevelopers();
        DeveloperDetailModel GetDeveloper(int id);
        void UpdateDeveloper(int id, DeveloperUpdateModel developerToUpdate);
        void DeleteDeveloper(int id);
    }
}
