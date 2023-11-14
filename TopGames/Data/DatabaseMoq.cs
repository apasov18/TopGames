using TopGames.Models;

namespace TopGames.Data
{
    public static class DatabaseMoq
    {
        public static List<SliderModel> Slides
        {
            get

            {
                List<SliderModel> slides = new List<SliderModel>()
                {


                    new SliderModel()
                    {
                        Title = "Alan Wake 2",
                        Url="1",
                        Image = "https://cdn2.unrealengine.com/egs-alan-wake-2-carousel-thumb-1200x1600-c64beec29b55.jpg?h=128&ampquality=medium&amp;resize=1&amp;w=96"
                    },
                    new SliderModel()
                    {
                        Title = "Alan Wake 2",
                        Url="2",
                        Image = "https://cdn2.unrealengine.com/egs-alan-wake-2-carousel-thumb-1200x1600-c64beec29b55.jpg?h=128&ampquality=medium&amp;resize=1&amp;w=96"
                    },
                    new SliderModel()
                    {
                        Title = "Alan Wake 2",
                        Url="3",
                        Image = "https://cdn2.unrealengine.com/egs-alan-wake-2-carousel-thumb-1200x1600-c64beec29b55.jpg?h=128&ampquality=medium&amp;resize=1&amp;w=96"
                    },
                    new SliderModel()
                    {
                        Title = "Alan Wake 3",
                        Url="4",
                        Image = "https://cdn2.unrealengine.com/egs-alan-wake-2-carousel-thumb-1200x1600-c64beec29b55.jpg?h=128&ampquality=medium&amp;resize=1&amp;w=96"
                    },
                    new SliderModel()
                    {
                        Title = "Alan Wake 2",
                        Url="5",
                        Image = "https://cdn2.unrealengine.com/egs-alan-wake-2-carousel-thumb-1200x1600-c64beec29b55.jpg?h=128&ampquality=medium&amp;resize=1&amp;w=96"
                    },
                    new SliderModel()
                    {
                        Title = "Alan Wake 2",
                        Url="6",
                        Image = "https://cdn2.unrealengine.com/egs-alan-wake-2-carousel-thumb-1200x1600-c64beec29b55.jpg?h=128&ampquality=medium&amp;resize=1&amp;w=96"
                    }

                };



                return slides;



            }
        }
    }
}
