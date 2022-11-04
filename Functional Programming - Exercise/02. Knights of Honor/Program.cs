using System;
using System.Threading.Channels;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> printName = (input) =>
            {
                foreach (var name in input)
                {
                    Console.WriteLine($"Sir {name}");
                }
            };

            var input = Console.ReadLine().Split();

            printName(input);
        }
    }
}
