using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Models.Switch
{
    public class SwitchGetAllModel
    {
        public int SwitchId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }
        public string DeveloperName { get; set; }
    }
}
