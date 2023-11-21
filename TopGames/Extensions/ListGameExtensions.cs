using TopGames.Models;

namespace TopGames.Extensions
{
    public static  class ListGameExtensions
    {
        public static List<SliderModel> GetSlides(this List<GameModel> games)
        {
            return  games.Where(g => g.IsSliderShow)
                 .Take(6)
                 .Select(g =>

                 {
                     SliderModel slider = g;
                     return slider;
                 }).ToList();
         
        }
    }
}
