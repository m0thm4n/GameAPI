using Game.Data.Entities;
using Game.Models.PC;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Game.Data
{
    public class PCGame
    {
        public PCGame()
        {
        }

        public PCGame(PCCreateModel pcGameToCreate)
        {
            Title = pcGameToCreate.Title;
            Price = pcGameToCreate.Price;
            Genre = pcGameToCreate.Genre;
            MaturityRating = pcGameToCreate.MaturityRating;
            Rating = pcGameToCreate.Rating;
            Publisher.Name = pcGameToCreate.Publisher;
            Developer.Name = pcGameToCreate.Developer;
        }

        public PCGame(PCDeleteModel pcGameToDelete)
        {
            Title = pcGameToDelete.Title;
            Price = pcGameToDelete.Price;
            Genre = pcGameToDelete.Genre;
            MaturityRating = pcGameToDelete.MaturityRating;
            Rating = pcGameToDelete.Rating;
            Publisher.Name = pcGameToDelete.Publisher;
            Developer.Name = pcGameToDelete.Developer;
        }

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
