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
        public string Name { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }
        public string MaturityRating { get; set; }
        public double Price { get; set; }
        [ForeignKey("Developer")]
        public int DeveloperId { get; set; }
        public virtual Developer Developer { get; set; }
        [ForeignKey("Publisher")]
        public int PublisherId { get; set; }
        public virtual Publisher Publisher { get; set; }

    }

}
