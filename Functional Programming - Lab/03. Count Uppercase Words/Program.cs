using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> isUpper = x => char.IsUpper(x[0]);

            var input = Console.ReadLine().Split().Where(x => isUpper(x));

            foreach (var capitalWord in input)
            {
                Console.WriteLine(capitalWord);
            }
        }
    }
}
