namespace TextAdventure
{
    public interface IInventory
    {
        int ItemCount { get; }

        void Add(Item item);
        bool Contains(string itemName);
        Item? Find(string itemName);
        Item? Find(string itemName, bool remove);
        void Remove(Item item);
        Item? Take(string itemName);
        void UseItem(string itemName, string user);
    }
}