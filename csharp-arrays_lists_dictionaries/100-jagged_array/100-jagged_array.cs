using System;

namespace _100_jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[][]
            {
                new int[] {0, 1, 2, 3},
                new int[] {0, 1, 2, 3, 4, 5, 6},
                new int[] {0, 1}
            };
            foreach (int[] col in jagged)
            {
                foreach (int row in col)
                {
                    Console.Write("{0}", row);
                    if (row != col[col.Length - 1])
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
