using System;
using System.Collections.Generic;

class List
{
  public static List<int> DifferentElements(List<int> list1, List<int> list2)
  {
    List<int> different_elements = new List<int>(list1);
    foreach (int num in list2)
    {
      if(different_elements.Contains(num))
      {
        different_elements.Remove(num);
      } else
      {
        different_elements.Add(num);
      }
    }
    different_elements.Sort();
    return different_elements;
  }
}