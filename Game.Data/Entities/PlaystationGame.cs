using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Data.Entities
{
    class PlaystationGame
    {
        [Key]
        public int PCGameId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Developer { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public double Rating { get; set; }
        [Required]
        public string MaturityRating { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}
