using System;
using System.Collections.Generic;

class Dictionary
{
  public static string BestScore(Dictionary<string, int> myList)
  {
    if(myList.Count == 0)
    {
      return "None";
    }
    int highest = 0;
    string person = "";
    foreach(KeyValuePair<string, int> kvp in myList)
    {
      if(kvp.Value >= highest)
      {
        highest = kvp.Value;
        person = kvp.Key;
      }
    }
    return person;
  }
}