using System;

public abstract class ItemObject
{
	#region Properties
	public string ID { get; protected set; }
	public string UID { get; protected set; }
	public string name { get; protected set; }
	public string description { get; protected set; }
	public float weight { get; protected set; }
	public int quanity { get; protected set; }
	#endregion
	
	#region Methods
	public void SetQuanity(int quanity)
	{
		if (this.UID != null)
			this.quanity = quanity;
	}
	#endregion
}
public class MiscItem : ItemObject
{
	#region Constructors
	public MiscItem(string ID, string name, string description, float weight)
	{
		this.ID = ID;
		this.UID = null;
		this.name = name;
		this.description = description;
		this.weight = weight;
		this.quanity = 1;
	} // Item generation
	public MiscItem(MiscItem item, int quanity)
	{
		this.ID = item.ID;
		this.UID = Guid.NewGuid().ToString();
		this.name = item.name;
		this.description = item.description;
		this.weight = item.weight;
		this.quanity = quanity;
	} // Adding to inventory
	#endregion
}
