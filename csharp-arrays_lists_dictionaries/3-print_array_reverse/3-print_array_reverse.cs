using System;

class Array
{
  public static void Reverse(int[] array)
  {
    if(array == null|| array.Length == 0)
    {
      Console.WriteLine();
      return;
    }
    int temp;
    int length = array.Length;

    for (int i = 0; i < (length/2); i++)
    {
      temp = array[i];
      array[i] = array[length - i - 1];
      array[length - i - 1] = temp;
    }
    for(int j = 0; j<length; j++)
    {
      Console.Write(array[j]);
      if(j < length - 1){
        Console.Write(" ");
      }
    }
    Console.WriteLine();
  }
}