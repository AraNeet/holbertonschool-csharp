using System;
using System.Collections.Generic;

namespace Text
{
  /// <summary>
  /// Represents a string utility class.
  /// </summary>
  public class Str
  {
    /// <summary>
    /// Determines if a string is a palindrome.
    /// </summary>
    /// <param name="s">string</param>
    /// <returns>boolean</returns>
    public static bool IsPalindrome(string s)
    {
      s = s.ToLower();

      List<char> sParsed = new List<char>();

      for (int i = 0; i < s.Length; i++)
      {
        if (s[i] >= 'a' && s[i] <= 'z')
        {
          sParsed.Add(s[i]);
        }
      }
      s = new string(sParsed.ToArray());
      
      char[] sCharArray = s.ToCharArray();
      Array.Reverse(sCharArray);
      string sReverse = new string(sCharArray);
      
      return s == sReverse;
    }
  }
}