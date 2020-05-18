using Game.Models.Xbox;
using System.Collections.Generic;

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
