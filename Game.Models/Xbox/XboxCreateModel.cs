using System.ComponentModel.DataAnnotations;

namespace Game.Models.Xbox
{
    public class XboxCreateModel
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
        [Required]
        public string Developer { get; set; }
        [Required]
        public string Publisher { get; set; }

    }
}
