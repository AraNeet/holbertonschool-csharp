using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int num = 0;
        foreach (int nodes in myLList)
        {
            num++;
        }
        return num;
    }
}