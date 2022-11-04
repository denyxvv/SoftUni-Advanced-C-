using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            Action<List<int>> reverseNums = numbers =>
            {
                numbers.Reverse();
            };

            List<int> numbersList = new List<int>(numbers);
            reverseNums(numbersList);

            foreach (var num in numbers)
            {
                if (num % n == 0)
                {
                    numbersList.Remove(num);
                }
            }

            Console.WriteLine(string.Join(" ", numbersList));

            
        }
    }
}
