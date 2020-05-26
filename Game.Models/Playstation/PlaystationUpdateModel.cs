﻿namespace Game.Models.Playstation
{
    public class PlaystationUpdateModel
    {
        public int PlaystationGameId { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }
        public string MaturityRating { get; set; }
        public decimal Price { get; set; }
    }
}
