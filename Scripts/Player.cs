using System;

public class Player : Entity
{
	public Player(string name)
	{
		this.name = name;
		this.healthPoints = maximumHealthPoints;
		CalculateAttributes();
	}
}
