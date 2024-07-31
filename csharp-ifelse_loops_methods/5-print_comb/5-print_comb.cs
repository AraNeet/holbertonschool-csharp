using System;

class Program
{
    public static void Main()
    {
        int num;
        for (num = 0; num <= 99; num++)
        {
            if (num <= 9)
            {
                Console.Write("0{0}, ", num);
            }
            else
            {
                if (num == 99)
                {
                    Console.Write("{0}\n", num);
                }
                else
                {
                    Console.Write("{0}, ", num);
                }
            }
        }
    }
}