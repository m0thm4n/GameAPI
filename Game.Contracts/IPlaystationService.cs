using Game.Models.Playstation;
using System.Collections.Generic;

namespace Game.Contracts
{
    public interface IPlaystationService
    {
        void CreatePlaystationGame(PlaystationGameCreateModel playstationGameToCreate);
        IEnumerable<PlaystationGameListModel> GetPlaystationGames();
        PlaystationGameModel GetPlaystationGame(int id);
        void UpdatePlaystationGame(int id, PlaystationUpdateModel playstationGameToUpdate);
        void DeletePlaystationGame(int id);
    }
}
