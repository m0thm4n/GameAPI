using Game.Data;
using Game.Models.XboxModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Contracts
{
    public interface IXboxService<XboxGame> 
    {
        void CreateXboxGame(XboxCreateModel xboxToCreate);
        IEnumerable<XboxGetAllModel> GetAllXboxGames();
        XboxDetailModel GetXboxGame(int id);
        void UpdateXboxGame(XboxUpdateModel xboxToUpdate);
        void DeleteXboxGame(int id);
    }
}
