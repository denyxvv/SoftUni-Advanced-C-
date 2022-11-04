using System;
using System.Threading.Channels;

namespace _01._Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> printName = (input) => Console.WriteLine(string.Join(Environment.NewLine, input));
            var input = Console.ReadLine().Split();

            printName(input);
        }
    }
}
