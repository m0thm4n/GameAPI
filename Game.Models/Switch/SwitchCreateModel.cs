using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Models.Switch
{
    public class SwitchCreateModel
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Genre { get; set; }

        public string MaturityRating { get; set; }

        public double Rating { get; set; }

        public int DeveloperId { get; set; }

        public int PublisherId { get; set; }
    }
}
