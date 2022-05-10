using System;

public class Attribute
{
	#region Constructors
	public Attribute(string name)
	{
		this.name = name;
		this.experience = 1;
	}
	#endregion
	
	#region Properties
	public string name { get; }
	public float experience { get; private set; }
	#endregion
	
	#region Methods
	public void AddExperience(float experience) => this.experience += experience;
	#endregion
}
