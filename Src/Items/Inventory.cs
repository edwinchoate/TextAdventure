
namespace TextAdventure
{
    public class Inventory : IInventory
    {

        private List<Item> Items { get; } = new();

        public int ItemCount => Items.Count;

        public void Add(Item item)
        {
            Items.Add(item);
        }

        public void Remove(Item item)
        {
            Items.Remove(item);
        }

        public Item? Find(string itemName)
        {
            foreach (Item item in Items)
            {
                if (item?.Name == itemName) return item;
            }
            return null;
        }

        public Item? Find(string itemName, bool remove)
        {
            Item? item = Find(itemName);
            if (item != null && remove) Items.Remove(item);
            return item;
        }

        public bool Contains(string itemName)
        {
            return Find(itemName) != null;
        }

        public Item? Take(string itemName)
        {
            return Find(itemName, remove: true);
        }

        public void UseItem(string itemName, string user)
        {
            Item? item = Find(itemName);
            if (item != null)
            {
                item.Use(user);
                if (!item.Reusable)
                    Remove(item);
            }
            else
            {
                Console.WriteLine(Text.StringResources.NoItemToUse, Text.AOrAn(itemName), itemName);
            }
        }

    }
}