using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myDict)
    {
        if (myDict.Count == 0)
        {
            return "None";
        }
        string player = "";
        int BestScore = 0;
        foreach (KeyValuePair<string, int> score in myDict)
        {
            if (BestScore < score.Value)
            {
                player = score.Key;
                BestScore = score.Value;
            }
        }
        return player;
    }
}