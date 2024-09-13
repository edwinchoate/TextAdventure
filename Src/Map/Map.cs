
namespace TextAdventure
{
    public partial class Map
    {
        public const int Width = 4; // TODO Size the map based on the real content I come up with
        public const int Height = 3;

        public Map (Player player)
        {
            Player = player;
        }
        
        public Cell[] Cells { get; private set; }
        public Player Player { get; }

    }
}