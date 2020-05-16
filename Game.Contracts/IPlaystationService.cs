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
        void CreatePlaystationGame(PlaystationGameCreateModel playstationGameToCreate);
        IEnumerable<PlaystationGameListModel> GetPlaystationGames();
        PlaystationGameModel GetPlaystationGame(int id);
        void UpdatePlaystationGame(int id, PlaystationUpdateModel playstationGameToUpdate);
        void DeletePlaystationGame(int id);
    }
}
