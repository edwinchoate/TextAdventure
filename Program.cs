using TextAdventure;


Console.WriteLine("Hullo, traveler. What's yer name?");

string name = Console.ReadLine();

while (name.Equals(String.Empty) || name == null)
{
    Console.WriteLine("I apologize. I'm hard of hearing in me old age. Could yah say yer name again?");
    name = Console.ReadLine();
}

Player player = new Player(name);

string a = "aeiouAEIOU".IndexOf(player.Name[0]) == -1 ? "a" : "an";
Console.WriteLine($"Aye. You look like {a} {player.Name}.");

