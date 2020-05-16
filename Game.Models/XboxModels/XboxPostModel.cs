﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Game.Models.XboxModels
{
    public class XboxPostModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public string MaturityRating { get; set; }
        [Required]
        public double Rating { get; set; }

    }
}

