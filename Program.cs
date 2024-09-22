using TextAdventure;

bool gameRunning = true;

Text.LoadStringResources(new EnglishStringResources());

Console.WriteLine(Text.StringResources.WhatsYourName);

string name = Console.ReadLine() ?? "";

while (name == null || name.Equals(String.Empty))
{
    Console.WriteLine(Text.StringResources.WhatsYourName2);
    name = Console.ReadLine() ?? "";
}

Player player = new Player(name);
Map map = new Map(player);

map.GenerateCells(); 
map.GoToStartingCell();

List<Item> items = new List<Item>()
{
    new Key(map),
    new Chest([new Gold(100)], map),
};
map.PopulateItems(items);

Invoker.Instance.Register(new Go(map));
Invoker.Instance.Register(new Bag(player));

Console.WriteLine(Text.StringResources.AffirmName, Text.AOrAn(player.Name), player.Name);

Cell? lastCell = null;

while(gameRunning)
{
    if (lastCell != map.CurrentCell)
    {
        lastCell = map.CurrentCell;
        Console.WriteLine(map.CurrentCell?.ToString());
    }

    string input = Console.ReadLine() ?? "";
    input = input.ToLower();

    if (input.Equals(Text.StringResources.Quit, StringComparison.OrdinalIgnoreCase))
    {
        gameRunning = false;
        Console.WriteLine(Text.StringResources.Farewell);
    }
    else
    {
        Invoker.Instance.Invoke(input.Split(" "));
    }

}
