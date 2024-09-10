
namespace TextAdventure
{
    public sealed class Invoker
    {

        private static Invoker? _instance;
        private readonly Dictionary<string, Command> _commands = new Dictionary<string, Command>();

        private Invoker() { }

        public static Invoker Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Invoker();
                return _instance;
            }
        }

        public void Register (Command command)
        {
            string name = command.Name.ToLower();
            if (_commands.ContainsKey(name))
                _commands[name] = command;
            else 
                _commands.Add(name, command);
        }

        public void Invoke (string[] args)
        {
            if (_commands.ContainsKey(args[0]))
                _commands[args[0]].Execute(args);
            else
                Console.WriteLine(Text.StringResources.CommandNotFound);
        }

    }
}