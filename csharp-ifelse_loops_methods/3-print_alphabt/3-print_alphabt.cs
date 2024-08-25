using System;

class Program
{
    static void Main()
    {
        for (char letter = 'a'; letter <= 'z'; letter++) {
            if (letter == 'e' || letter == 'q') {
                continue;
            } else {
                Console.Write("{0}", letter);
            }
        }
    }
}
