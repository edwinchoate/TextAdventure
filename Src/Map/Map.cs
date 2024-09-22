
namespace TextAdventure
{
    public partial class Map
    {
        public const int Width = 4; // TODO Size the map based on the real content I come up with
        public const int Height = 3;

        public readonly Random _random = new Random(1234);

        public Map (Player player)
        {
            Player = player;
            Cells = new Cell[Width*Height];
        }
        
        public Cell[] Cells { get; private set; }
        public Player Player { get; }

    }
}