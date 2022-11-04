﻿using System;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string word = Console.ReadLine();

            char[,] matrix = new char[dimensions[0], dimensions[1]];

            int currWordIndex = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (currWordIndex == word.Length)
                        {
                            currWordIndex = 0;
                        }

                        matrix[row, col] = word[currWordIndex];
                        currWordIndex++;
                    }

                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        if (currWordIndex == word.Length)
                        {
                            currWordIndex = 0;
                        }

                        matrix[row, col] = word[currWordIndex];
                        currWordIndex++;
                    }
                }
            }

            PrintMatrix(matrix);
        }

        static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}