using TextAdventure;


Console.WriteLine("Hullo, traveler. What's yer name?");

string input = Console.ReadLine();

while (input.Equals(String.Empty) || input == null)
{
    Console.WriteLine("I apologize. I'm hard of hearing in me old age. Could yah say yer name again?");
    input = Console.ReadLine();
}

Player player = new Player(input);

string a = "aeiouAEIOU".IndexOf(player.Name[0]) == -1 ? "a" : "an";
Console.WriteLine($"Aye. You look like {a} {player.Name}.");

