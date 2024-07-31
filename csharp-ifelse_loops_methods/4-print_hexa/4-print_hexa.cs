using System;

class Program
{
    public static void Main()
    {
        int num;
        for (num = 0; num <= 98; num++)
        {
            Console.Write("{0} = 0x{1}\n", num, num.ToString("x"));
        }
    }
}