
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
                select d.ToLower()
            ).ToArray();

            sb.Append("\n");

            if (openPassages.Length > 1)
            {
                sb.Append($"{Text.StringResources.PassagesDescIntro} ")
                  .Append(Text.CommaSeparatedList(openPassages));
            }
            else
            {
                sb.Append($"{Text.StringResources.PassageDescIntro} ")
                  .Append(openPassages[0]);
            }

            sb.Append(".");

            return sb.ToString();
        }

    }
}