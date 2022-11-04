using System;

namespace _02._Wall_Destroyer
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int currRow = 0;
            int currCol = 0;


            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                    if (input[col] == 'V')
                    {
                        currRow = row;
                        currCol = col;
                    }
                }
            }

            string command = Console.ReadLine().ToLower();
            int countOfHoles = 1;
            int rods = 0;
            matrix[currRow, currCol] = '*';
            bool isDead = false;

            while (command != "end")
            {
                int oldRow = currRow;
                int oldCol = currCol;
                switch (command)
                {
                    case "up":
                        currRow--;
                        break;
                    case "down":
                        currRow++;
                        break;
                    case "left":
                        currCol--;
                        break;
                    case "right":
                        currCol++;
                        break;
                }

                if (currRow >= 0 && currRow < n && currCol >= 0 && currCol < n)
                {
                    if (matrix[currRow, currCol] == 'R')
                    {
                        Console.WriteLine("Vanko hit a rod!");
                        rods++;
                        currRow = oldRow;
                        currCol = oldCol;
                    }
                    else if (matrix[currRow, currCol] == '-')
                    {
                        countOfHoles++;
                        matrix[currRow, currCol] = '*';
                    }
                    else if (matrix[currRow, currCol] == '*')
                    {
                        Console.WriteLine($"The wall is already destroyed at position [{currRow}, {currCol}]!");
                    }
                    else if (matrix[currRow, currCol] == 'C')
                    {
                        matrix[currRow, currCol] = 'E';
                        isDead = true;
                        countOfHoles++;
                        break;
                    }
                    else
                    {
                        currRow = oldRow;
                        currCol = oldCol;
                    }

                    command = Console.ReadLine().ToLower();
                }

                if (isDead)
                {
                    Console.WriteLine($"Vanko got electrocuted, but he managed to make {countOfHoles} hole(s).");
                }
                else
                {
                    Console.WriteLine($"Vanko managed to make {countOfHoles} hole(s) and he hit only {rods} rod(s).");
                }

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        Console.Write(matrix[row, col]);
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
