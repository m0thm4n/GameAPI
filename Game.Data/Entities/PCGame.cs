using Game.Models.PC;
using System.ComponentModel.DataAnnotations;

namespace Game.Data
{
    public class PCGame
    {
        public PCGame(PCCreateModel pcGameToCreate)
        {
            Title = pcGameToCreate.Title;
            Price = pcGameToCreate.Price;
            Genre = pcGameToCreate.Genre;
            MaturityRating = pcGameToCreate.MaturityRating;
            Rating = pcGameToCreate.Rating;
            Publisher = pcGameToCreate.Publisher;
            Developer = pcGameToCreate.Developer;
        }

        public PCGame(PCDeleteModel pcGameToDelete)
        {
            Title = pcGameToDelete.Title;
            Price = pcGameToDelete.Price;
            Genre = pcGameToDelete.Genre;
            MaturityRating = pcGameToDelete.MaturityRating;
            Rating = pcGameToDelete.Rating;
            Publisher = pcGameToDelete.Publisher;
            Developer = pcGameToDelete.Developer;
        }

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
