
namespace TextAdventure
{
    public class Bag : Command
    {

        private readonly IInventory _inventory;

        public Bag (IInventory inventory)
        {
            _inventory = inventory;
        }

        public override string Name => Text.StringResources.BagCommandName;

        public override void Execute(string[] args)
        {
            Console.WriteLine(String.Format(Text.StringResources.BagSummary, _inventory.ItemCount.ToString()));
            
            foreach (string item in _inventory.ItemNames)
            {
                Console.WriteLine(String.Format("    {0}", item));
            }
        }

    }
}
