using System;

namespace Game.Models.XboxModels
{
    public class XboxPostModel
    {
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field.")]
        public string Name { get; set; }

        public double Price { get; set; }
        public double Rating { get; set; }
        public string MaturityRating { get; set; }
        public string Genre { get; set; }
        

    }
}


