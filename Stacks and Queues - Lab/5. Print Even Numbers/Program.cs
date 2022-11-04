using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Queue<int> queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToList());
            List<int> validNums = new List<int>();

            foreach (var num in queue)
            {
                if (num % 2 == 0)
                {
                    validNums.Add(num);
                }
            }

            Console.WriteLine(string.Join(", ", validNums));

        }
    }
}
