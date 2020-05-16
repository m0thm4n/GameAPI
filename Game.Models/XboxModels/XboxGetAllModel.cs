using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Game.Models.XboxModels
{
    public class XboxGetAllModel
    {
        public int XboxId { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }
        public string MaturityRating { get; set; }

    }
}
