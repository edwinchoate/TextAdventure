
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
            int itemCount = _inventory.ItemCount;

            Console.WriteLine(
                String.Format(
                    Text.StringResources.BagSummary, itemCount.ToString(), Text.SingularOrPlural(Text.StringResources.Item, itemCount)
                )
            );
            
            foreach (string item in _inventory.ItemNames)
            {
                Console.WriteLine(String.Format("    {0}", item));
            }
        }

    }
}
