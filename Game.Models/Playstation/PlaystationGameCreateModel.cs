using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Models.Playstation
{
    public class PlaystationGameCreateModel
    {
        public int PlaystationGameId { get; set; }
        public string Title { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }
        public string MaturityRating { get; set; }
        public decimal Price { get; set; }
    }
}
