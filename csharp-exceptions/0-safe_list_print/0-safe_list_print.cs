using System;
using System.Collections.Generic;

class List
{
  public static int SafePrint(List<int> myList, int n)
  {
    int num = 0;
    try
    {
      while (num < n)
      {
        Console.WriteLine(myList[num]);
        num++;
      }
    }
    catch (System.ArgumentOutOfRangeException)
    {

    }
    return num;
  }
}
