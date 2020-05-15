using Game.Models.Playstation;
using System.Collections.Generic;

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
