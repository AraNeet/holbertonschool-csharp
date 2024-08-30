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
      if (s.Length == 0)
      {
        return true;
      }
      s = s.ToLower();
      for(int i = 0; i < s.Length / 2; i++)
      {
        if (s[i] != s[s.Length - i - 1])
        {
          return false;
        }
      }
      return true;
    }
  }
}