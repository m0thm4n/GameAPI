using System.ComponentModel.DataAnnotations;

namespace Game.Data.Entities
{
    public class PlaystationGame
    {
        [Key]
        public int PlaystationGameId { get; set; }
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
