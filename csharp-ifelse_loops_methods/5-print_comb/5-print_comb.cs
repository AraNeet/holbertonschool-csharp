using System;
class Program
{
    static void Main()
    {
        for (int num = 0; num <= 99; num++) {
            if (num == 99) {
                Console.Write("{0}\n", num);
            }else {
                Console.Write("{0}, ", num.ToString("00"));
            }
        }
    }
}
