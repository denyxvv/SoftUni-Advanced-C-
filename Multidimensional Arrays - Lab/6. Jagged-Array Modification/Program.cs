using System;
using System.Linq;
using System.Runtime.ConstrainedExecution;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[][] jaggedArray = new int[3][];

            //jaggedArray[0] = new int[2]
            //{
            //    1, 2
            //};
            //jaggedArray[1] = new int[3]
            //{
            //    1,2,3
            //};
            //jaggedArray[2] = new int[4]
            //{
            //    5,6,7,8
            //};

            //Console.WriteLine(jaggedArray[0].Length);
            //Console.WriteLine(jaggedArray[1].Length);

            //for (int row = 0; row < jaggedArray.Length; row++)
            //{
            //    for (int col = 0; col < jaggedArray[row].Length; col++)
            //    {
            //        Console.Write($"{jaggedArray[row][col]} ");
            //    }
            //    Console.WriteLine();
            //}

            //---------------------------------------------

            //int rows = int.Parse(Console.ReadLine());
            //int[][] jaggedArray = new int[rows][];

            //for (int row = 0; row < rows; row++)
            //{
            //    Console.Write($"COLS ? jagged[{row}]=");
            //    int cols = int.Parse(Console.ReadLine());
            //    jaggedArray[row] = new int[cols];
            //    for (int col = 0; col < cols; col++)
            //    {
            //        jaggedArray[row][col] = int.Parse(Console.ReadLine());
            //    }
            //}

            //------------------------------------
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                jaggedArray[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            foreach (int[] row in jaggedArray)
            {
                Console.WriteLine(string.Join(" ",row));
            }

            //Console.WriteLine("FINAL");
            //for (int row = 0; row < jaggedArray.Length; row++)
            //{
            //    for (int col = 0; col < jaggedArray[row].Length; col++)
            //    {
                    
            //        Console.Write($"{jaggedArray[row][col]} ");
            //    }

            //    Console.WriteLine();
            //}

           




        }
    }
}
