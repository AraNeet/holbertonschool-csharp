using System;
using System.Collections.Generic;

class LList
{
  public static int Pop(LinkedList<int> myLList)
  {
    if(myLList.Count == 0)
    {
      return 0;
    }
    int firstNode = myLList.First.Value;
    myLList.RemoveFirst();
    return firstNode;
  }
}


// Write a method that deletes the head node of a LinkedList and returns that node’s data.

// Class Name: LList
// Prototype: public static int Pop(LinkedList<int> myLList)
// Returns the value of the head node
// If the list is empty, return 0