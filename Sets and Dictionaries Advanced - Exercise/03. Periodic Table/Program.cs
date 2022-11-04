using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> elements = new HashSet<string>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] newElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < newElements.Length; j++)
                {
                    var add = elements.Add(newElements[j]);
                }

            }

            Console.WriteLine(string.Join(" ", elements.OrderBy(x => x)));
        }
    }
}
