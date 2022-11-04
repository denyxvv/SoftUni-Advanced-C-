using System;
using System.Linq;

namespace _7._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            long[][] pascal = new long[rows][];

            for (int row = 0; row < rows; row++)
            {
                pascal[row] = new long[row + 1];
                for (int col = 0; col < pascal[row].Length; col++)
                {

                    if (row == 0)
                    {
                        pascal[row][col] = 1;
                        continue;
                    }
                    long currValue = 0;

                    if (col > 0 && row > 0)
                    {
                        currValue = pascal[row - 1][col - 1];
                    }

                    if (pascal[row].Length - 1 > col)
                    {
                        currValue += pascal[row - 1][col];
                    }

                    pascal[row][col] = currValue;
                }
            }

            foreach (long[] row in pascal)
            {
                Console.WriteLine(string.Join(" ", row));
            }

        }
    }
}