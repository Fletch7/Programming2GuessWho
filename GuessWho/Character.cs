using System;

public class Character
{

	public string Name { get; set; }
    public Image Placeholder {  get; set; }
    public Dictionary<string, string> Attributes { get; set; }
    public bool Hat {  get; set; }
    public string EyeColour {  get; set; }
	
	public Character(string name, Image placeholder, Dictionary<string, string> attributes, bool hat, string eyeColour)
	{
		this.Name = name;
		this.Placeholder = placeholder;
		this.Attributes = attributes;
		this.Hat = hat;
		this.EyeColour = eyeColour;
    }

	


}
