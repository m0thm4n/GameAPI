using System.ComponentModel.DataAnnotations;

namespace Game.Models.Xbox
{
    public class XboxCreateModel
    {
        
        public string Name { get; set; }
        
        public decimal Price { get; set; }
        
        public string Genre { get; set; }
        
        public string MaturityRating { get; set; }
        
        public double Rating { get; set; }
        
        public int DeveloperId { get; set; }
        
        public int PublisherId { get; set; }

    }
}
