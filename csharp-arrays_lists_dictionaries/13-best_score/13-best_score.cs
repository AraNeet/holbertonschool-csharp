using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count == 0)
        {
            return "None";
        }
        string player = "";
        int BestScore = 0;
        foreach (KeyValuePair<string, int> score in myList)
        {
            if (BestScore <= score.Value)
            {
                player = score.Key;
                BestScore = score.Value;
            }
        }
        return player;
    }
}