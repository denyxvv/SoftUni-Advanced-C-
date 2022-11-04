using System;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            char[,] matrix = new char[N, N];

            for (int i = 0; i < N; i++)
            {
                char[] colElements = Console.ReadLine().ToCharArray();

                for (int col = 0; col < N; col++)
                {
                    matrix[i, col] = colElements[col];
                }
            }

            char symbol = char.Parse(Console.ReadLine());

            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    if (matrix[row,col] == symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{symbol} does not occur in the matrix");
        }
    }
}
