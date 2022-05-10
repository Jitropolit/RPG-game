using System;
using System.Collections.Generic;
using static Methods;

public abstract class Entity
{
	public string name { get; protected set; }
	public float healthPoints { get; protected set; }
	public float maximumHealthPoints { get; private set; }

	private List<Attribute> attributes = Data.dataAttributes;
	private Inventory inventory = new Inventory();
	
	#region Methods
	public float GetAttributeExperience(string name)
	{
		return TryFindAttribute(name).experience;
	}
	public void AddAttributeExperience(string name, float experience)
	{
		TryFindAttribute(name).AddExperience(experience);
		CalculateAttributes();
	}
	private Attribute TryFindAttribute(string name)
	{
		return attributes.Find(attribute => attribute.name.ToLower() == name);
	}
	protected void CalculateAttributes()
	{
		float strength = GetAttributeExperience("strength");
		maximumHealthPoints = strength * 100;
		inventory.SetMaximumWeight(15 + strength * 1.25f);
	}
	
	public Inventory GetInventory() => new Inventory(inventory);
	public void AddInventoryItem(string ID, int quanity) => inventory.AddItem(ID, quanity);
	public void ExistsInventoryItem(string ID) => inventory.ExistsItem(ID);
	public void TryFindInventoryItem(string ID) => inventory.TryFindItem(ID);
	#endregion
}
