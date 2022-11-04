using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Dictionary<double, int> numberTimes = new Dictionary<double, int>();

            foreach (var number in nums)
            {
                if (!numberTimes.ContainsKey(number))
                {
                    numberTimes.Add(number, 0);
                }

                numberTimes[number]++;
                
            }

            foreach (var item in numberTimes)
            {

                Console.WriteLine($"{item.Key} - {item.Value} times");
            }


        }
    }
}
