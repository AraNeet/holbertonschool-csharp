using System;

class Program
{
    public static void Main()
    {
        int num;
        for (num = 0; num <= 100; num++)
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.Write("FizzBuzz ");
            }
            else if (num % 3 == 0)
            {
                Console.Write("Fizz ");
            }
            else if (num % 5 == 0)
            {
                Console.Write("Buzz ");
            }
            else
            {
                Console.Write("{0} ", num);
            }
        }
        Console.WriteLine("");
    }
}