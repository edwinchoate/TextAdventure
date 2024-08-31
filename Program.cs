

Console.WriteLine("Hullo, traveler. What's yer name?");

string name = Console.ReadLine();

while (name.Equals(String.Empty) || name == null)
{
    Console.WriteLine("I apologize. I'm hard of hearing in me old age. Could yah say yer name again?");
    name = Console.ReadLine();
}

name = name[0].ToString().ToUpper() + name.Substring(1);

string a = "aeiouAEIOU".IndexOf(name[0]) == -1 ? "a" : "an";
Console.WriteLine($"Aye. You look like {a} {name}.");

