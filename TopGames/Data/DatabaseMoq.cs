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
                        Title = "Assassin’s Creed Mirage",
                        Url="2",
                        Image = "https://cdn2.unrealengine.com/egs-ac-mirage-master-assassin-carousel-thumb-1200x1600-04b784b5228f.jpg?h=128&ampquality=medium&ampresize=1&ampw=96"
                    },
                    new SliderModel()
                    {
                        Title = "Return to Moria™",
                        Url="3",
                        Image = "https://cdn2.unrealengine.com/egs-lotr-return-to-moria-carousel-thumb-v2-1200x1600-5d5f6bd3b206.jpg?h=128&quality=medium&resize=1&w=96"
                    },
                    new SliderModel()
                    {
                        Title = "Honkai: Star Rail",
                        Url="4",
                        Image = "https://cdn2.unrealengine.com/en-egs-honkai-star-rail-1-5-carousel-thumb-1200x1600-85873137956e.jpg?h=128&quality=medium&resize=1&w=96"
                    },
                    new SliderModel()
                    {
                        Title = "Suicide Squad: Kill the Justice League - Deluxe Edition",
                        Url="5",
                        Image = "https://cdn2.unrealengine.com/egs-suicide-squad-ktjl-deluxe-carousel-thumb-1200x1600-bd5a43909d22.jpg?h=128&quality=medium&resize=1&w=96"
                    },
                    new SliderModel()
                    {
                        Title = "Banishers: Ghosts of New Eden",
                        Url="6",
                        Image = "https://cdn2.unrealengine.com/egs-banishers-ghosts-of-new-eden-carousel-mobile-thumb-1200x1600-976575969b7b.jpg?h=128&quality=medium&resize=1&w=96"
                    }

                };
                return slides;
            }
        }


        public static List<GameModel> Games { get; set; }

        static DatabaseMoq()
        {

             Games = new List<GameModel>()
                {


                    new GameModel()
                    {
                        Id= Guid.NewGuid(),
                        Title = "Car Mechanic - City Driving",
                        UrlImage="https://cdn1.epicgames.com/spt-assets/be29ee7e2f14449d822b76bf52e8f5ab/car-mechanic--city-driving-17nkn.png?h=480&quality=medium&resize=1&w=360",
                        Price=250,
                        Discount=50,
                        IsSliderShow = true,
                        Background="#005050",
                        ButtonColor="#0074e4"

                    },
                    new GameModel()
                    {
                         Id= Guid.NewGuid(),
                        Title = "Achilles Legends Untold",
                        UrlImage="https://cdn1.epicgames.com/spt-assets/aec31192b8a6463c9bd43dcb6ece5c8f/achilles-legends-untold-trjaz.jpg?h=480&quality=medium&resize=1&w=360",
                        Price=530,
                        Discount=30,
                        IsSliderShow = true,
                        
                        Background="#005050",
                        ButtonColor="#0074e4"


                    },
                    new GameModel()
                    {
                         Id= Guid.NewGuid(),
                        Title = "Hanoi Puzzles - Solid Match",
                        UrlImage="https://cdn1.epicgames.com/spt-assets/58e43b2cb77d4087882873f43831b6a1/hanoi-puzzles--solid-match-c5eqt.png?h=480&quality=medium&resize=1&w=360",
                        Price=239,
                        Discount=33,
                        IsSliderShow = true,
                        Background="#005050",
                        ButtonColor="#0074e4"



                    },
                    new GameModel()
                    {
                         Id= Guid.NewGuid(),
                        Title = "Ghoul Castle 3D - Gold Edition",
                        UrlImage="https://cdn1.epicgames.com/spt-assets/2402ff8ccf5647828483c9e8880e3cce/ghoul-castle-3d--gold-edition-rchv0.png?h=480&quality=medium&resize=1&w=360",
                        Price=659,
                        Discount=20,
                        IsSliderShow = true,
                        Background="#005050",
                        ButtonColor="#0074e4"


                    },
                    new GameModel()
                    {
                         Id= Guid.NewGuid(),
                        Title = "Island Farmer",
                        UrlImage="https://cdn1.epicgames.com/spt-assets/3fb5be523b7a46d39f9b2da081fad744/island-farmer-1keo0.jpg?h=480&quality=medium&resize=1&w=360",
                        Price=759,
                        Discount=10,
                        IsSliderShow = true,
                        Background="#005050",
                        ButtonColor="#0074e4"


                    },
                    new GameModel()
                    {
                        Id= Guid.NewGuid(),
                        Title = "GINSHA",
                        UrlImage="https://cdn1.epicgames.com/spt-assets/d9cf30b30233475dbcf56055db33c826/ginsha-11fm9.jpg?h=480&quality=medium&resize=1&w=360",
                        Price=450,
                        Discount=43,
                        IsSliderShow = true,
                        Background="#005050",
                        ButtonColor="#0074e4"


                    }
                };
            
        }
        
            
        
    }
}
