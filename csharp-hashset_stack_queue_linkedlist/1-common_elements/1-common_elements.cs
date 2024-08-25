using System;
using System.Collections.Generic;

class List
{
  public static List<int> CommonElements(List<int> list1, List<int> list2)
  {
     HashSet<int> list1_elements = new HashSet<int>(list1);
     List<int> common_elements = new List<int>();
     
     foreach(int num in list2)
     {
      if(list1_elements.Contains(num))
      {
        common_elements.Add(num);
      }
     }
     return common_elements;
  }
}