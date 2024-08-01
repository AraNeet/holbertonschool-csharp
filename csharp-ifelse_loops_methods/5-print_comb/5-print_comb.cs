using System;

class Program
{
    public static void Main()
    {
        int num;
        for (num = 1; num <= 99; num++)
        {
            if (num == 99)
            {
                Console.Write("{0}\n", num);
                break;
            }
            Console.Write("{0:D2}, ", num);
        }
    }
}