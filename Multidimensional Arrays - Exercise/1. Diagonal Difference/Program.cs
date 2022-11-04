using System;
using System.Data;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[,] matrix = new int[N, N];

            for (int row = 0; row < N; row++)
            {
                int[] matrixInfo = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int col = 0; col < N; col++)
                {
                    matrix[row, col] = matrixInfo[col];
                }
            }
            int primarySum = 0;
            int secondarySum = 0;

            for (int i = 0 ; i < N; i++)
            {
                primarySum += matrix[i, i];
                secondarySum += matrix[i, N - i - 1];
            }

            Console.WriteLine(Math.Abs(primarySum - secondarySum));
        }
    }
}
