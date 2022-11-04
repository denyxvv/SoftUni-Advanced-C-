using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int subMatrixRows = 2;
            int subMatrixCols = 2;
            string[] sizes = Console.ReadLine().Split(", ");
            int rows = int.Parse(sizes[0]);
            int cols = int.Parse(sizes[1]);
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] matrixInfo = Console.ReadLine().Split(", ");

                for (int col = 0; col < cols; col++)
                {
                    matrix[i, col] = int.Parse(matrixInfo[col]);
                }
            }

            int maxSum = 0;
            int squareStarRow = 0;
            int squareStarCol = 0;

            for (int row = 0; row < rows - subMatrixRows + 1; row++)
            {
                for (int col = 0; col < cols - subMatrixCols + 1; col++)
                {
                    int sum = 0;
                    sum += matrix[row, col];
                    sum += matrix[row + 1, col];
                    sum += matrix[row, col + 1];
                    sum += matrix[row + 1, col + 1];

                    if (sum > maxSum)
                    {
                        squareStarRow = row;
                        squareStarCol = col;
                        maxSum = sum;
                    }
                }
            }

            Console.WriteLine($"{matrix[squareStarRow, squareStarCol]} {matrix[squareStarRow, squareStarCol + 1]}");
            Console.WriteLine($"{matrix[squareStarRow + 1, squareStarCol]} {matrix[squareStarRow + 1, squareStarCol + 1]}");

            Console.WriteLine(maxSum);
        }
    }
}
