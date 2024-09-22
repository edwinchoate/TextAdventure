
namespace TextAdventure
{
    public class Use : Command
    {

        private readonly Map _map;

        public Use (Map map)
        {
            _map = map;
        }

        public override string Name => Text.StringResources.UseCommandName;

        public override void Execute (string[] args)
        {
            if (args.Length <= 1)
            {
                Console.WriteLine(Text.StringResources.UseError);
                return;
            }
            else
            {
                string itemName = args[1];

                if (_map.Player.Contains(itemName))
                {
                    _map.Player.UseItem(itemName, _map.Player.Name);
                    Console.WriteLine(String.Format(Text.StringResources.ItemUsed, itemName));
                }
                else
                {
                    Console.WriteLine(Text.StringResources.UseError);
                }
            }
        }

    }
}