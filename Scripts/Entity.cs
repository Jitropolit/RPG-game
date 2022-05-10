using System;
using System.Collections.Generic;
using static Methods;

public abstract class Entity
{
	#region Properties
	public string name { get; protected set; }
	public float healthPoints { get; protected set; }
	public float maximumHealthPoints { get; private set; }
	#endregion
	
	#region Fields
	protected List<Attribute> attributes;
	protected Inventory inventory;
	#endregion
	
	#region Methods
	public void AddAttributeExperience(string name, float experience)
	{
		TryFindAttribute(name).AddExperience(experience);
		CalculateAttributes();
	}
	public float GetAttributeExperience(string name) => TryFindAttribute(name).experience;
	private Attribute TryFindAttribute(string name) => attributes.Find(attribute => attribute.name.ToLower() == name);
	protected void CalculateAttributes()
	{
		float strength = GetAttributeExperience("strength");
		maximumHealthPoints = 100 + strength * 15;
		inventory.SetMaximumWeight(15 + strength * 1.25f);
	}
	
	public void AddInventoryItem(string ID, int quanity) => inventory.AddItem(ID, quanity);
	public void TryFindInventoryItem(string ID) => inventory.TryFindItem(ID);
	public void ExistsInventoryItem(string ID) => inventory.ExistsItem(ID);
	public Inventory GetInventory() => new Inventory(inventory);
	#endregion
}
