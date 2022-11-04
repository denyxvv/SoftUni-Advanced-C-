using System;
using System.Linq;
using System.Threading.Channels;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[,] matrix = new int[N ,N];

            for (int i = 0; i < N; i++)
            {
                int[] matrixInfo = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int col = 0; col < N; col++)
                {
                    matrix[i, col] = matrixInfo[col];
                }
            }
                int sum = 0;

            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    sum += matrix[row, col];
                    row++;
                }
            }

            Console.WriteLine(sum);

            
        }
    }
}
