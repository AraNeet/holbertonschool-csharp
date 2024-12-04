using System;
using System.Collections.Generic;


class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> newDict = new List<string>(myDict.Keys);
        newDict.Sort();

        foreach (var key in newDict)
        {
            Console.WriteLine("{0}: {1}", key, myDict[key]);
        }
    }
    
}