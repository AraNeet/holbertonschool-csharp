using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> newDict = new Dictionary<string, int>(myDict);
        int value;
        foreach (var key in newDict.Keys)
        {
            value = newDict[key];
            value *= 2;
            newDict[key] = value;
        }

        return newDict;
    }
