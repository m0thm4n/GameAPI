using Game.Data.Entities;
using Game.Models.PC;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Game.Data
{
    public class PCGame
    {
        [Key]
        public int PCGameId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public double Rating { get; set; }
        [Required]
        public string MaturityRating { get; set; }
        [Required]
        public decimal Price { get; set; }

        [ForeignKey("Developer")]
        public int DeveloperId { get; set; }
        public virtual Developer Developer { get; set; }

        [ForeignKey("Publisher")]
        public int PublisherId { get; set; }
        public virtual Publisher Publisher { get; set; }

    }
}
