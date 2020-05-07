﻿using System;

namespace Game.Models.XboxModels
{
    public class XboxPostModel
    {
        [Required]
        public string Name { get; set; }
        public double Price { get; set; }
        public double Rating { get; set; }
        public string MaturityRating { get; set; }
        public string Genre { get; set; }

    }
}


