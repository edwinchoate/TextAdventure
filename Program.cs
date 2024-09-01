using TextAdventure;

var strings = new EnglishStringResources();

Console.WriteLine(strings.WhatsYourName);

string name = Console.ReadLine();

while (name.Equals(String.Empty) || name == null)
{
    Console.WriteLine(strings.WhatsYourName2);
    name = Console.ReadLine();
}

Player player = new Player(name);

Console.WriteLine($"{strings.AffirmName} {TextUtils.AOrAn(player.Name)} {player.Name}.");

