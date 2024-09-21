
using System.Runtime.CompilerServices;

namespace TextAdventure
{
    public class Chest : Item, IInventory
    {

        private readonly Map _map;
        private readonly Inventory _inventory = new();

        public Chest(Item[] items, Map map)
        {
            _map = map;

            Takeable = false;
            Reusable = false;

            foreach (Item item in items)
            {
                Add(item);
            }
        }

        public bool Locked => true;

        public override string Name => Text.StringResources.Chest;

        public override void Use(string user)
        {
            if (user == Text.StringResources.Key)
            {
                if (Locked)
                    Console.WriteLine(Text.StringResources.YouUnlockedChest);

                if (_inventory.ItemCount == 0)
                    Console.WriteLine(Text.StringResources.ChestIsEmpty);
                else
                {
                    foreach (string itemName in ItemNames)
                    {
                        var item = Take(itemName);
                        if (item != null)
                        {
                            _map.Player.Add(item);
                            Console.WriteLine(String.Format(Text.StringResources.ItemAcquired), itemName);
                        }
                    }
                }
            }
        }

        public int ItemCount => ((IInventory)_inventory).ItemCount;

        public string[] ItemNames => ((IInventory)_inventory).ItemNames;

        public void Add(Item item)
        {
            ((IInventory)_inventory).Add(item);
        }

        public bool Contains(string itemName)
        {
            return ((IInventory)_inventory).Contains(itemName);
        }

        public Item? Find(string itemName)
        {
            return ((IInventory)_inventory).Find(itemName);
        }

        public Item? Find(string itemName, bool remove)
        {
            return ((IInventory)_inventory).Find(itemName, remove);
        }

        public void Remove(Item item)
        {
            ((IInventory)_inventory).Remove(item);
        }

        public Item? Take(string itemName)
        {
            return ((IInventory)_inventory).Take(itemName);
        }

        public void UseItem(string itemName, string user)
        {
            ((IInventory)_inventory).UseItem(itemName, user);
        }
    }
}