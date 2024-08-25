using System;

class Array
{
  public static int[] CreatePrint(int size)
  {
    if(size == 0)
    {
      Console.WriteLine();
    } else if(size < 0)
    {
      Console.WriteLine("Size cannot be negative");
      return null;
    }

    int[] arr = new int[size];
    for(int i = 0; i < size; i++)
    {
      arr[i] = i;
    }
    foreach(int num in arr)
    {
      Console.Write($"{num}");
      if(num < arr.Length-1)
      {
        Console.Write(" ");
      } else{
        Console.WriteLine();
      }
    }
    return arr;
  }
}