using System;

class Program
{
    public static void Main()
    {
        char abc;
        for (abc = 'a'; abc <= 'z'; abc++)
        {
            if (abc != 'q' && abc != 'e')
            {
                Console.Write("{0}", abc);
            }
        }
    }
}