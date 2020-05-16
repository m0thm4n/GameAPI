using System;

namespace Game.Models.XboxModels
{
    public class XboxDetailModel
    {
        public int XboxId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }
        public string MaturityRating { get; set; }
        public double Rating { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }

    }
}
