namespace TopGames.Models
{
    public class SliderModel
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public bool IsHover { get; set; }
        public bool IsActive { get; set; }
        public string Url { get; set; }
        public static implicit operator SliderModel(GameModel game)
        {
            return new SliderModel()
            {
                Title = game.Title,
                Image = game.UrlImage,
                Url = game.Title
            };

        }
    }
}
