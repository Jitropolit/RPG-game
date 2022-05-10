using System;
using System.Collections.Generic;
using static Methods;

public class Inventory
{
	public Inventory()
	{
		this.weight = 0;
		this.maximumWeight = 0;
		this.storage = new List<ItemObject>();
	}
	public Inventory(Inventory inventory)
	{
		this.weight = inventory.weight;
		this.maximumWeight = inventory.maximumWeight;
		this.storage = inventory.storage;
	}
	
	public float weight { get; protected set; }
	public float maximumWeight { get; protected set; }
	public List<ItemObject> storage;
	
	#region Methods
	public void SetMaximumWeight(float maximumWeight)
	{
		this.maximumWeight = maximumWeight;
	}
	private void CalculateWeight()
	{
		float weightBuffer = 0;
		foreach(ItemObject item in storage)
		{
			weightBuffer += item.quanity * item.weight;
		}
		weight = weightBuffer;
	}
	
	public void AddItem(string ID, int quanity)
	{
		if (ExistsItem(ID))
			TryFindItem(ID).SetQuanity(TryFindItem(ID).quanity + quanity);
		else
			storage.Add(new MiscItem((MiscItem)TryFindDataItem(ID), quanity));
		CalculateWeight();
	}
	public bool ExistsItem(string ID) => storage.Exists(item => item.ID == ID);
	public ItemObject TryFindItem(string ID) => storage.Find(item => item.ID == ID);
	#endregion
}
