using System;

///<summary>
/// Base class
/// </summary>
abstract class Base
{
  public string name = "";

	public override string ToString()
	{
		return (this.name + " is a " + this.GetType().ToString());
	}
}

/// <summary>
/// Interactive interface
/// </summary>
interface IInteractive
{
    void Interact();
}

/// <summary>
/// Breakable Interface
/// </summary>
interface IBreakable
{
    int durability { get; set; }
    void Break();
}

/// <summary>
/// Collectable Interface
/// </summary>
interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();

}
/// <summary>
/// Door class
/// </summary>
class Door : Base, IInteractive
{
    public Door(string name = "Door")
    {
        this.name = name;
    }
    public void Interact()
    {
        Console.WriteLine($"You try to open the {this.name}. It's locked.");
    }
}