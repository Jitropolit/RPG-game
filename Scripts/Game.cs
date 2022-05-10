using Godot;
using System;
using static Methods;

public class Game : Node
{
	private Player localPlayer = new Player("Dred Nord");

	public override void _Ready()
	{	
		localPlayer.AddInventoryItem("fork", 32);
		localPlayer.AddInventoryItem("spoon", 12);
		
		string buffer = null;
		buffer += $"name = {localPlayer.name}\n";
		buffer += $"healthPoints = {localPlayer.healthPoints}\n";
		buffer += $"maximumHealthPoints = {localPlayer.maximumHealthPoints}\n";
		buffer += $"\tstrength = {localPlayer.GetAttributeExperience("strength")}\n";
		buffer += $"inventory.weight = {localPlayer.GetInventory().weight}\n";
		buffer += $"inventory.maximumWeight = {localPlayer.GetInventory().maximumWeight}\n";
		foreach(ItemObject item in localPlayer.GetInventory().storage)
		{
			buffer += $"\t{item.ID} / {item.UID} / {item.name} / {item.description} / {item.weight} / {item.quanity}\n";
		}
		GD.Print(buffer);
//		for(int i = 0; i < 5; i++)
//		{
//			localPlayer.inventory.AddItem("fork", new Random().Next(1, 13));
//			DebugLog();
//		}
	}
	private void DebugLog()
	{
		foreach(ItemObject item in localPlayer.GetInventory().storage)
		{
			GD.Print($"{item.ID} / {item.UID} / {item.name} / {item.description} / {item.weight} / {item.quanity}");
		}
	}
}
