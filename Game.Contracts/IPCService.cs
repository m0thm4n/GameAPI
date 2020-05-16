using Game.Models.PC;
using System.Collections.Generic;

namespace Game.Contracts
{
    public interface IPCService
    {
        void CreatePCGame(PCCreateModel pcGameToCreate);
        List<PCListModel> GetPCList();
        void UpdatePCGame(PCUpdateModel pcGameToUpdate);
        void DeleteGame(PCDeleteModel pcGameToDelete);
    }
}
