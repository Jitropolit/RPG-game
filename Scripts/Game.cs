using Godot;
using System;
using System.Collections.Generic;
using static Methods;

public class Game : Node
{
	public override void _Ready()
	{
		List<DialogueTree.Dialogue> dialogues = new List<DialogueTree.Dialogue>()
		{
			new DialogueTree.Dialogue(1, "Babka: Privet Danila", new Dictionary<string, int>()
			{
				{"Idi naxui", 2},
				{"Ya ne donilo", 3},
				{"Da privet", 4}
			}),
			new DialogueTree.Dialogue(2, "Babka: Sam idi naxui", new Dictionary<string, int>()
			{
				{"A mojet ti pidor", 0},
				{"Slish gnida patlataya", 0}
			}),
			new DialogueTree.Dialogue(3, "Babka: Ti mudilo", new Dictionary<string, int>()
			{
				{"A mojet ti pidor", 0},
				{"Slish gnida patlataya", 0}
			}),
			new DialogueTree.Dialogue(4, "Babka: Kak dela?", new Dictionary<string, int>()
			{
				{"Poka ne rodila", 5},
				{"Mne nekogda", 0}
			}),
			new DialogueTree.Dialogue(5, "Babka: Blin tak nesmeshno je", new Dictionary<string, int>()
			{
				{"Zahodit kakto stalker v bar", 0}
			})
		};
		DialogueTree dialogueWithBabka = new DialogueTree(dialogues);
		dialogueWithBabka.StartDialogue();
		dialogueWithBabka.SwitchDialogue(4);
		dialogueWithBabka.SwitchDialogue(5);
	}
	public void DebugLog()
	{
		Player localPlayer = new Player("Dred Nord");
		
		localPlayer.AddAttributeExperience("strength", 3);
		
		//localPlayer.AddInventoryItem("fork", 32);
		//localPlayer.AddInventoryItem("spoon", 12);
		//localPlayer.AddInventoryItem("coin", 10537);
		
		string buffer = null;
		buffer += $"name = {localPlayer.name}\n";
		buffer += $"healthPoints = {localPlayer.healthPoints}\n";
		buffer += $"maximumHealthPoints = {localPlayer.maximumHealthPoints}\n";
		buffer += $"\tstrength = {localPlayer.GetAttributeExperience("strength")}\n";
		buffer += $"\tvitality = {localPlayer.GetAttributeExperience("vitality")}\n";
		buffer += $"\ttoughness = {localPlayer.GetAttributeExperience("toughness")}\n";
		buffer += $"inventory.weight = {localPlayer.GetInventory().weight}\n";
		buffer += $"inventory.maximumWeight = {localPlayer.GetInventory().maximumWeight}\n";
		foreach(ItemObject item in localPlayer.GetInventory().storage)
		{
			buffer += $"\t{item.ID} / {item.UID} / {item.name} / {item.description} / {item.weight} / {item.quanity}\n";
		}
		GD.Print(buffer);
	}
}
