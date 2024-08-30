using System;

namespace Enemies
{
  /// <summary>Represents zombie Class</summary>
  public class Zombie
  {
    private int health;
    private string name = "(No name)";

    /// <summary>Initializes zombie instnace</summary>
    public Zombie()
    {
      health = 0;
    }

    /// <summary>Instnace of Zombie with value parameter.</summary>
    public Zombie(int value)
    {
      if(value >= 0)
      {
        health = value;
      }
      else{
        throw new ArgumentException("Health must be greater than or equal to 0");
      }
    }
    /// <summary>
    /// Gets the value of the health property
    /// </summary>
    /// <returns>health</returns>
    public int GetHealth()
    {
      return health;
    }

    /// <summary>
    /// Name Getter and Setter
    /// </summary>
    /// <value></value>
    public string Name
    {
      get {return name;}
      set {name = value;}
    }
    /// <summary>
    /// Overrides ToString
    /// </summary>
    /// <returns>Zombie Name and health</returns>
    public override string ToString()
    {
      return $"Zombie Name: {this.Name} / Total Health: {GetHealth()}";
    }
  }
}