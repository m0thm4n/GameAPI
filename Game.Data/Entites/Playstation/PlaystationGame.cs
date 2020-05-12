using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Data.Entites.PlaystationGame
{
    public class PlaystationGame
    {
        [Key]
        public int PlaystationGameId { get; set; }
        public string Name { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }
        public double Rating { get; set; }
        public string MaturityRating { get; set; }
        public decimal Price { get; set; }
    }
}
