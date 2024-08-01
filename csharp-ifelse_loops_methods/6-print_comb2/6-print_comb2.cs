using System;

class Program
{
    public static void Main()
    {
        int numa; 
        int numb = 0;
        for (numa = 0; numa <= 8; numa++)
        {
            for (numb = numa + 1; numb <= 9; numb++)
            {
                if (numa == 8 && numb == 9)
                {
                    Console.Write("{0}{1}\n", numa, numb);
                }
                else 
                {
                    Console.Write("{0}{1}, ", numa, numb);
                }
            }
        }
    }
}