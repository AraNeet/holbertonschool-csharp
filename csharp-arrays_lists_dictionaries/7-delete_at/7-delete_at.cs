using System;
using System.Collections.Generic;

class List
{
  public static List<int> DeleteAt(List<int> myList, int index)
  {
    List<int> newList = new List<int>();

    if(index < 0 || index >= myList.Count)
    {
      Console.WriteLine("Index is out of range");
      return myList;
    }
    else
    {
      myList.Remove(myList[index]);
    }
    return myList;
  }
}
