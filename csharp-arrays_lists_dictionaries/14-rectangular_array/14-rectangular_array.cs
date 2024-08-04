using System;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = {{0,0,0,0,0},{0,0,0,0,0},{0,0,1,0,0},{0,0,0,0,0},{0,0,0,0,0}};

            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    if (col + 1 == 5)
                    {
                        Console.Write("{0}", array[row, col]);
                    }
                    else
                    {
                        Console.Write("{0} ", array[row, col]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
