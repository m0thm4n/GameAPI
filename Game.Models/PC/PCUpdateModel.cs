namespace Game.Models.PC
{
    public class PCUpdateModel
    {
        public int PCGameId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public double Rating { get; set; }
        public string Genre { get; set; }
        public string Publisher { get; set; }
        public string Developer { get; set; }
        public string MaturityRating { get; set; }

    }
}
