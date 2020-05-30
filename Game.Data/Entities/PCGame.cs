using Game.Models.PC;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
<<<<<<< Updated upstream
using System.Linq;
using System.Text;
using System.Threading.Tasks;
=======
using System.ComponentModel.DataAnnotations.Schema;
>>>>>>> Stashed changes

namespace Game.Data
{
    public class PCGame
    {
<<<<<<< Updated upstream
        public PCGame(PCCreateModel pcGameToCreate)
        {
            Title = pcGameToCreate.Title;
            Price = pcGameToCreate.Price;
            Genre = pcGameToCreate.Genre;
            MaturityRating = pcGameToCreate.MaturityRating;
            Rating = pcGameToCreate.Rating;
            PublisherId = pcGameToCreate.Publisher;
            DeveloperId = pcGameToCreate.Developer;
        }

        public PCGame(PCDeleteModel pcGameToDelete)
        {
            Title = pcGameToDelete.Title;
            Price = pcGameToDelete.Price;
            Genre = pcGameToDelete.Genre;
            MaturityRating = pcGameToDelete.MaturityRating;
            Rating = pcGameToDelete.Rating;
            PublisherId = pcGameToDelete.Publisher;
            DeveloperId = pcGameToDelete.Developer;
        }

=======
>>>>>>> Stashed changes
        [Key]
        public int PCGameId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [ForeignKey("Developer")]
        public string DeveloperId { get; set; }
        [Required]
        [ForeignKey("Publisher")]
        public string PublisherId { get; set; }
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
