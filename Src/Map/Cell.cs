
namespace TextAdventure
{
    public class Cell
    {

        public string ShortDescription { get; set; } = "";

        public Dictionary<Directions, int> Neighbors { get; set; } = new Dictionary<Directions, int>()
        {
            {Directions.North, -1},
            {Directions.South, -1},
            {Directions.East, -1},
            {Directions.West, -1}
        };

        public bool Visited { get; set; }

    }
}