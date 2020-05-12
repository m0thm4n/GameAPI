using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Data
{
    public class XboxGame
    {
        [Key]
        public int XboxId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public double Rating { get; set; }
        [Required]
        public string MaturityRating { get; set; }
        [Required]
        public decimal Price { get; set; }
        //ToDo: Make Dev & Pub into ForeignKeys?
        public string Developer { get; set; }
        public string Publisher { get; set; }

    }

}
