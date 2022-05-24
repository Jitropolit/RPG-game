using System;

public class Player : Entity
{
	#region Constructors
	public Player(string name)
	{
		this.attributes = Data.dataAttributes;
		this.inventory = new Inventory();
		CalculateAttributes();
		
		this.name = name;
		this.healthPoints = maximumHealthPoints;
	}
	#endregion
}
