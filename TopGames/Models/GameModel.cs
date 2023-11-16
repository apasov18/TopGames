namespace TopGames.Models
{
    public class GameModel
    {
        public Guid Id { get; set; }

        public string UrlImage { get; set; }

        public string Title { get; set; }   

        public double Discount { get; set; }

        public double Price { get; set; }

    }
}
