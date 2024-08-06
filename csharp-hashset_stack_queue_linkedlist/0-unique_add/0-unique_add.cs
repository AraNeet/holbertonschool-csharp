using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        int sum = 0;
        HashSet<int> myHash = new HashSet<int>(myList);

        foreach (int num in myHash)
        {
            sum += num;
        }
        return sum;
    }
}