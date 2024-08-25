using System;

class Program
{
    static void Main()
    {
        int num1, num2;
        for (num1 = 0; num1 <= 9; num1++) {
            for (num2 = 1; num2 <= 9; num2++) {
                if (num1 == 8 && num2 == 9) {
                    Console.Write("{0}{1}\n", num1, num2);
                } else if (num1 >= num2) {
                    continue;
                } else {
                    Console.Write("{0}{1}, ", num1, num2);
                }
            }
        }
    }
}
