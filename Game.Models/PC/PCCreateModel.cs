using System.ComponentModel.DataAnnotations;

namespace Game.Models.PC
{
    public class PCCreateModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public string MaturityRating { get; set; }
        [Required]
        public double Rating { get; set; }
        public string Publisher { get; set; }
        public string Developer { get; set; }
    }
}
