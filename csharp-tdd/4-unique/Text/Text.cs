namespace Text{

  /// <summary>
  /// Represents a string utility class.
  /// </summary>
  public class Str
  {
    /// <summary>
    /// Returns the index of the first unique character in a string.
    /// </summary>
    /// <param name="s">string</param>
    /// <returns>index of first unique character</returns>
    public static int UniqueChar(string s)
    {
      if(s == null)
      {
        return -1;
      }
      if(s.Length == 1)
      {
        return 0;
      }
      for(int i = 0; i < s.Length; i++)
        {
          if (s.Substring(i + 1).Contains(s[i].ToString()) == false && s.Substring(0, i).Contains(s[i].ToString()) == false)
          {
              return i;
          }
        }
      return -1;
    }
  }
}