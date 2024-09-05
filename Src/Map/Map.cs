
namespace TextAdventure
{
    public partial class Map
    {

        public Map (Player player)
        {
            Player = player;
        }

        public int Width { get; set; }
        public int Height { get; set; }
        public Cell[,] Cells { get; private set; }
        public Player Player { get; }

    }
}