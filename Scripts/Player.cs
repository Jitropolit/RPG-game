using System;

public class Player : Entity
{
	#region Constructors
	public Player(string name)
	{
		this.name = name;
		this.healthPoints = maximumHealthPoints;
		this.attributes = Data.dataAttributes;
		this.inventory = new Inventory();
		CalculateAttributes();
	}
	#endregion
}
