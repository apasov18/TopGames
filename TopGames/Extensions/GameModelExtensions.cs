using TopGames.Models;
using TopGames.Pages;

namespace TopGames.Extensions
{
    public static class GameModelExtensions
    {
        public static double DiscountPrice(this GameModel game)
        {

            return game.Price * (1 - (game.Discount / 100));

        }
    }
}
