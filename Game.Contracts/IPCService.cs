using Game.Models.PC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
