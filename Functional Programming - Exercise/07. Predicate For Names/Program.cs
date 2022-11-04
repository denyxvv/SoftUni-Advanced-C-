using System;

namespace _07._Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Action<string[]> printNamesLessThan = names =>
            {
                foreach (var name in names)
                {
                    if (name.Length <= n)
                    {
                        Console.WriteLine(name);
                    }
                }
            };

            var names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            printNamesLessThan(names);
        }
    }
}
