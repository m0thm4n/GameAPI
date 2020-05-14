using Game.Models.Playstation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Contracts
{
    public interface IPlaystationService
    {
        void CreatePCGame(PlaystationGameCreateModel playstationGameToCreate);
        List<PlaystationGameListModel> GetPlaystationGameList();
        PlaystationGameModel GetPlaystationGame();
        void UpdatePCGame(PlaystationUpdateModel pcGameToUpdate);
        void DeleteGame(PlaystationDeleteModel pcGameToDelete);
    }
}
