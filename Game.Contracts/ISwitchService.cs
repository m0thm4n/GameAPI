using Game.Models.Switch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Contracts
{
    public interface ISwitchService
    {
        void CreateSwitchGame(SwitchCreateModel switchToCreate);
        IEnumerable<SwitchGetAllModel> GetAllSwitchGames();
        SwitchDetailsModel GetSwitchGame(int id);
        void UpdateSwitchGame(int id, SwitchUpdateModel switchToUpdate);
        void DeleteSwitchGame(int id);
    }
}
