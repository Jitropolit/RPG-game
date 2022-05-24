using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

public static class Data
{
	public static List<ItemObject> dataItems = new List<ItemObject>()
	{
		new MiscItem("coin", "Coin", "Shiny coin.", .0065f),
		new MiscItem("fork", "Fork", "It's the silver Fork.", .036f),
		new MiscItem("spoon", "Spoon", "It's the silver Spoon.", .036f)
	};
	public static List<Attribute> dataAttributes = new List<Attribute>()
	{
		new Attribute("Strength"),
		new Attribute("Vitality"),
		new Attribute("Toughness"),

		new Attribute("Agility"),
		new Attribute("Speed"),
		new Attribute("Endurance"),
 
		new Attribute("Intelligence"),
		new Attribute("Charisma"),
		new Attribute("Tactics")
	};
}
