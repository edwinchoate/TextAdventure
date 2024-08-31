using TextAdventure;


Console.WriteLine("Hullo, traveler. What's yer name?");

string name = Console.ReadLine();

while (name.Equals(String.Empty) || name == null)
{
    Console.WriteLine("I apologize. I'm hard of hearing in me old age. Could yah say yer name again?");
    name = Console.ReadLine();
}

Player player = new Player(name);

Console.WriteLine($"Aye. You look like {TextUtils.AOrAn(player.Name)} {player.Name}.");

