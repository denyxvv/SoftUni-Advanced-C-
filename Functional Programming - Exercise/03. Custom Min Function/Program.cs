using System;
using System.Linq;
using System.Threading.Channels;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> minFunc = (input) =>
            {
                int min = input.Min();
                return min;
            };
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(minFunc(input));
        }
    }
}
