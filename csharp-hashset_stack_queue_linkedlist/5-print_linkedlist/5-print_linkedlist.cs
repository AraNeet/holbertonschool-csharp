using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        if (size < 0)
            return new LinkedList<int>();

        LinkedList<int> link = new LinkedList<int>();

        for (int i = 0; i < size; i++)
        {
            link.AddFirst(i);
            Console.WriteLine(i);
        }
        return link;
    }
}