using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        } else if (size == 0)
        {
            Console.WriteLine();
        }

        int[] Array = new int[size];
        for (int i = 0; i < size; i++)
        {
            Array[i] = i;
        }

        foreach (int num in Array)
        {
            Console.Write($"{num}");
            if (num < Array.Length - 1)
            {
                Console.Write(" ");
            }
            else
            {
                Console.WriteLine();
            }
        }
        return Array;
    }
}