using Game.Models.PC;
using System.Collections.Generic;

namespace Game.Contracts
{
    public interface IPCService
    {
        void CreatePCGame(PCCreateModel pcGameToCreate);
        IEnumerable<PCListModel> GetPCGames();
        PCListModel GetPCGame(int id);
        void UpdatePCGame(int id, PCUpdateModel pcGameToUpdate);
        void DeleteGame(int id);
    }
}
