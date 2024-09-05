
namespace TextAdventure
{
    public partial class Map
    {

        private readonly Random _random = new Random(1234);

        public Map (Player player)
        {
            Player = player;
        }

        public Player Player { get; }

    }
}