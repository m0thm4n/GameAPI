using Game.Models.Xbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Contracts
{
    public interface IXboxService
    {
        void CreateXboxGame(XboxCreateModel xboxToCreate);
        IEnumerable<XboxGetAllGamesModel> GetAllXboxGames();
        XboxDetailsModel GetXboxGame(int id);
        void UpdateXboxGame(XboxUpdatesModel xboxToUpdate);
        void DeleteXboxGame(int id);
    }
}
