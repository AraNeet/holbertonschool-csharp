using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> MyList)
    {
        if (MyList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return -1;
        }
        int greatest = MyList[0];
        for (int i = 0; i < MyList.Count; i++)
        {
            if (MyList[i] > greatest)
            {
                greatest = i;
            }
        }

        return greatest;
    }
}