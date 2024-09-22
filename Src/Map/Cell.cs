
using System.Text;

namespace TextAdventure
{
    public class Cell : IInventory
    {
        private readonly IInventory _inventory = new Inventory();

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

        public int ItemCount => _inventory.ItemCount;

        public string[] ItemNames => _inventory.ItemNames;

        public void Add(Item item)
        {
            _inventory.Add(item);
        }

        public bool Contains(string itemName)
        {
            return _inventory.Contains(itemName);
        }

        public Item? Find(string itemName)
        {
            return _inventory.Find(itemName);
        }

        public Item? Find(string itemName, bool remove)
        {
            return _inventory.Find(itemName, remove);
        }

        public void Remove(Item item)
        {
            _inventory.Remove(item);
        }

        public Item? Take(string itemName)
        {
            return _inventory.Take(itemName);
        }

        public void UseItem(string itemName, string user)
        {
            _inventory.UseItem(itemName, user);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            // TODO if (Visited)
                sb.Append(ShortDescription);
            //else
            //  sb.Append(LongDescription);

            if (ItemCount > 0)
            {
                sb.Append('\n');
                
                sb.Append(Text.StringResources.YouSee + ": ");

                sb.Append(Text.CommaSeparatedList(ItemNames, Text.StringResources.And));
            }

            string[] directionStrings = Enum.GetNames(typeof(Directions));

            string[] openPassages = (
                from d in directionStrings 
                where Neighbors[(Directions)Enum.Parse(typeof(Directions), d)] > -1 
                select d.ToLower()
            ).ToArray();

            sb.Append('\n');

            if (openPassages.Length > 1)
            {
                sb.Append(
                    String.Format(
                        Text.StringResources.PassagesDescIntro, 
                        Text.CommaSeparatedList(openPassages, Text.StringResources.And))
                );
            }
            else
            {
                sb.Append(String.Format(Text.StringResources.PassageDescIntro, openPassages[0]));
            }

            sb.Append('.');

            return sb.ToString();
        }

    }
}