
namespace TextAdventure
{
    public class Take : Command
    {

        private readonly Map _map;

        public Take (Map map)
        {
            _map = map;
        }
        
        public override string Name => Text.StringResources.TakeCommandName;

        public override void Execute(string[] args)
        {

            if (_map.CurrentCell != null)
            {
                if (args.Length == 1)
                {
                    Console.WriteLine(Text.StringResources.TakeError);
                    return;
                }

                string itemName = args[1];

                if (_map.CurrentCell.Contains(itemName))
                {
                    Item? item = _map.CurrentCell.Take(itemName);
                    if (item != null)
                    {
                        if (item.Takeable == false)
                            Console.WriteLine(String.Format(Text.StringResources.CantTake, item.Name));
                        else
                        {
                            _map.Player.Add(item);
                            Console.WriteLine(String.Format(Text.StringResources.TookDesc, item.Name));
                        }
                    }
                }
                else
                {
                    Console.WriteLine(Text.StringResources.TakeError);
                }
            }
            else
            {
                throw new NullReferenceException();
            }
        }

    }
}