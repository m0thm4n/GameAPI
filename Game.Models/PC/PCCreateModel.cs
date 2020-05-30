using System.ComponentModel.DataAnnotations;

namespace Game.Models.PC
{
    public class PCCreateModel
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }
        public string MaturityRating { get; set; }
        public double Rating { get; set; }
        public int PublisherId { get; set; }
        public int DeveloperId { get; set; }
    }
}
