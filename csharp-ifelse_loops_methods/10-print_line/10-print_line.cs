using System;

class Line
{
    public static void PrintLine(int length)
    {
        int x;
        if (length <= 0)
        {
            Console.Write("\n");
        }
        else
        {
            for (x = 0; x <= length; x++)
            {
                if (x == length)
                {
                    Console.Write("\n");
                }
                else if (x < length)
                {
                    Console.Write("{0}", x.ToString("_"));
                }
            }
        }
    }
}