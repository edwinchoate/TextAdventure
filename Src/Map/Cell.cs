
using System.Text;

namespace TextAdventure
{
    public class Cell
    {

        public string ShortDescription { get; set; } = "";

        public Dictionary<Directions, int> Neighbors { get; set; } = new Dictionary<Directions, int>()
        {
            {Directions.None, -1 },
            {Directions.North, -1},
            {Directions.South, -1},
            {Directions.East, -1},
            {Directions.West, -1}
        };

        public bool Visited { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            // TODO if (Visited)
                sb.Append(ShortDescription);
            //else
            //  sb.Append(LongDescription);

            string[] directionStrings = Enum.GetNames(typeof(Directions));

            string[] openPassages = (
                from d in directionStrings 
                where Neighbors[(Directions)Enum.Parse(typeof(Directions), d)] > -1 
                select d
            ).ToArray();

            // TODO insert "and" into the list 

            sb.Append(String.Format("\n{0} ", Text.StringResources.PassagesDescIntro));
            sb.Append(String.Join(", ", openPassages)).Append(".");

            return sb.ToString();
        }

    }
}