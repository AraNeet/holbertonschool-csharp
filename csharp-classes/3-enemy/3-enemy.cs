using System;

namespace Enemies
{
  /// <summary>Represents zombie Class</summary>
  public class Zombie
  {
    /// <summary>Represents zombie health</summary>
    private int health;

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
  }
}