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
/// TestObject class
/// </summary>
class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability { get; set; }
    public bool isCollected { get; set; }

    /// <summary>
    /// Takes place when the object interacts.
    /// </summary>
    public void Interact()
    {
        // Method implementation
    }

    /// <summary>
    /// Takes place when the object breaks.
    /// </summary>
    public void Break()
    {
        // Method implementation
    }

    /// <summary>
    /// Takes place when the object collects something.
    /// </summary>
    public void Collect()
    {
        // Method implementation
    }
}