
namespace TextAdventure
{
    public class Go : Command
    {
        private readonly Map _map;

        public Go (Map map)
        {
            _map = map;
        }

        public override string Name { get => Text.StringResources.GoCommandName; }

        public override void Execute(string[] args)
        {

            if (_map.CurrentCell != null)
            {
                string directionArg = args[1].Substring(0, 1).ToUpper() + args[1].Substring(1).ToLower();

                Enum.TryParse(directionArg, out Directions direction); // a failed parse will automatically set direction to None

                int cellIndex = _map.CurrentCell.Neighbors[direction];

                if (cellIndex == -1 || direction == Directions.None)
                    Console.WriteLine(Text.StringResources.GoCommandError);
                else
                    _map.GoToCell(cellIndex);
            }
            else
            {
                throw new NullReferenceException();
            }

        }

    }
}