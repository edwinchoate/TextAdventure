using TextAdventure;

TextUtils.LoadStringResources(new EnglishStringResources());

Console.WriteLine(TextUtils.StringResources.WhatsYourName);

string name = Console.ReadLine();

while (name.Equals(String.Empty) || name == null)
{
    Console.WriteLine(TextUtils.StringResources.WhatsYourName2);
    name = Console.ReadLine();
}

Player player = new Player(name);

Console.WriteLine(TextUtils.StringResources.AffirmName, TextUtils.AOrAn(player.Name), player.Name);

