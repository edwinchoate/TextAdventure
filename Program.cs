﻿using TextAdventure;

Text.LoadStringResources(new EnglishStringResources());

Console.WriteLine(Text.StringResources.WhatsYourName);

string name = Console.ReadLine();

while (name.Equals(String.Empty) || name == null)
{
    Console.WriteLine(Text.StringResources.WhatsYourName2);
    name = Console.ReadLine();
}

Player player = new Player(name);
Map map = new Map(player);

Console.WriteLine(Text.StringResources.AffirmName, Text.AOrAn(player.Name), player.Name);

