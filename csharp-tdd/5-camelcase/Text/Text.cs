using System;

namespace Text
{
  /// <summary>
  /// Represents a string utility class.
  /// </summary>
  public class Str
  {
    /// <summary>
    /// This method returns the number of words in a camel case string.
    /// </summary>
    /// <param name="s">string</param>
    /// <returns> number of words</returns>
    public static int CamelCase(string s)
    {
      if (s == null || s.Length <= 0)
      {
        return 0;
      }

      int words = 1;
      int count = 0;
      
      if(s[0] >= 'A' || s[0] <= 'Z')
      {
        count++;
      }
      while (count < s.Length)
      {
        if (s[count] >= 'A' && s[count] <= 'Z')
        {
          words++;
        }
        count++;
      }

      return words;
    }
  }
}