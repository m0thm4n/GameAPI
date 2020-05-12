using Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Contracts
{
    public interface IPlaystationGameService
    {
        void CreateGame(PlaystationGameCreateModel playstationGameToCreate);
        IEnumerable<PlaystationGameItemList> GetGames();
        PlaystationGameItem GetGame(int id);
        void UpdateGame(int id);
        void DeleteGame(int id);
    }
}
