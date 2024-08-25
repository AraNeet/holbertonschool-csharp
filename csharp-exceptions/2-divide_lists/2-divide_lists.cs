using System;
using System.Collections.Generic;

class List
{
  public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
  {
    int i = 0;
    List<int> results = new List<int>();

    while( i < listLength)
    {
      try
      {
        results.Add( list1[i] / list2[i] );
      }
      catch (ArgumentOutOfRangeException)
      {
        Console.WriteLine("Out of range");
      }
      catch(DivideByZeroException)
      {
        Console.WriteLine("Cannot divide by zero");
        results.Add(0);
      }
      i++;
    }
    return results;
  }
}
// Write a function that divides element by element 2 lists.

// Class Name: List
// Prototype: public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
// length can be bigger than the length of either list
// Returns a new list of all division results
// If 2 elements can’t be divided, the division result should be equal to 0
// If the division can’t be done (dividing by 0):
// print Cannot divide by zero
// If either list is too short:
// print Out of range
// You have to use try / catch