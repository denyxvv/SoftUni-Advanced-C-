using System;
using System.Linq;

namespace _03._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            nums = nums.OrderByDescending(x => x).Take(3).ToArray();

            //if (nums.Length < 3)
            //{
                Console.WriteLine(string.Join(" ",nums));
            //}
            //else
            //{
            //    for (int i = 0; i < 3; i++)
            //    {
            //        Console.Write($"{sorted[i]} ");
            //    }
            //}
        }
    }
}
