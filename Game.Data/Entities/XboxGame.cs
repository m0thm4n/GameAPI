using System.ComponentModel.DataAnnotations;

namespace Game.Data.Entities
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
