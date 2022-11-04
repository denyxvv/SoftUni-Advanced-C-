using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Even_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();

            Predicate<int> isEven = input => input % 2 == 0;
            Predicate<int> isOdd = input => input % 2 != 0;

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string oddOrEven = Console.ReadLine();

            if (oddOrEven == "even")
            {
                for (int i = input[0]; i <= input[1]; i++)
                {
                    if (isEven(i))
                    {
                        nums.Add(i);
                    }
                }
            }
            else
            {
                for (int i = input[0]; i <= input[1]; i++)
                {
                    if (isOdd(i))
                    {
                        nums.Add(i);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", nums));

        }
    }
}
