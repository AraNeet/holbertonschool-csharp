using System;

class Program
{
    static void Main()
    {
        for (int number = 0; number <= 98; number++) {
            Console.Write("{0} = 0x{1}\n", number, number.ToString("x"));
        }
    }
}
