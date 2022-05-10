using System;

public class Attribute
{
	public Attribute(string name)
	{
		this.name = name;
		this.experience = 1;
	}
	
	public string name { get; }
	public float experience { get; private set; }
	
	#region Methods
	public void AddExperience(float experience)
	{
		this.experience += experience;
	}
	#endregion
}
