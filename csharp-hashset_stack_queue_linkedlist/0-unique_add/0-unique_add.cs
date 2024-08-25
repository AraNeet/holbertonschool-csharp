using System;
using System.Collections.Generic;

class List
{
  public static int Sum(List<int> myList)
  {
    HashSet<int> newSet = new HashSet<int>();
    int sum = 0;
    for(int i = 0; i < myList.Count; i++)
    {
      newSet.Add(myList[i]);
    }
    foreach(int num in newSet)
    {
      sum += num;
    }
    return sum;
  }
}