using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array == null)
        {
            Console.WriteLine();
            return;
        }
        for (int index = array.Length - 1; index >= 0; index--)
        {
            Console.Write(array[index] + " ");
        }
        Console.WriteLine();
    }
}