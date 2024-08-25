using System;
using System.Collections.Generic;

class LList
{
  public static int Length(LinkedList<int> myLList)
  {
    int size = 0;

    foreach(int node in myLList)
    {
      size++;
    }
    return size;
  }
}