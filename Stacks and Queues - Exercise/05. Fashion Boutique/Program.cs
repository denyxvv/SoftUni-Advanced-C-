using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothesValue = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());
            Stack<int> clothes = new Stack<int>(clothesValue);
            double sum = 0;
            int rackCount = 0;

            while (clothes.Count != 0)
            {
                if (sum - clothes.Peek() < 0)
                {
                    rackCount++;
                    sum = rackCapacity;
                }
                else
                {
                    sum -= clothes.Pop();
                }

            }

            Console.WriteLine(rackCount);


        }
    }
}
