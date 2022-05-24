using Godot;
using System;
using System.Collections.Generic;

public class DialogueTree
{
	public DialogueTree(List<Dialogue> dialogues)
	{
		this.dialogueTree =  dialogues;
	}
	public class Dialogue
	{
		public Dialogue(int ID, string text, Dictionary<string, int> answers)
		{
			this.ID = ID;
			this.text = text;
			this.answers = answers;
		}
		
		public int ID { get; private set; }
		public string text { get; private set; }
		public Dictionary<string, int> answers = new Dictionary<string, int>();
	}
	
	public int currentID { get; private set; }
	private List<Dialogue> dialogueTree = new List<Dialogue>();
	
	public void StartDialogue()
	{
		SwitchDialogue(1);
	}
	public void SwitchDialogue(int ID)
	{
		currentID = ID;
		Dialogue dialogue = TryFindDialogue(ID);

		string buffer = null;
		buffer += $"{dialogue.text} {dialogue.ID}\n";
		foreach (KeyValuePair<string, int> _dialogue in dialogue.answers)
		{
			buffer += $"\t{_dialogue.Key} {_dialogue.Value}" + "\n";
		}
		GD.Print(buffer);
	}
	private Dialogue TryFindDialogue(int ID) => dialogueTree.Find(dialogue => dialogue.ID == ID);
}
