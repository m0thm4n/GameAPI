using System;

namespace Game.Models.XboxModels
{
    public class XboxDetailModel
    {
        public int XboxId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Rating { get; set; }
        public string MaturityRating { get; set; }
        public string Genre { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }

    }
}
