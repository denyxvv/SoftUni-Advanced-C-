using System;
using System.Collections.Generic;

namespace _07.Tuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] nameAndLocation = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] nameAndLitresBeer = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] intAndDouble = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Tuple<string, string> nameAndAddres = new Tuple<string, string>
            {
                item1 = $"{nameAndLocation[0]} {nameAndLocation[1]}",
                item2 = nameAndLocation[2]
            };

            Tuple<string, int> nameAndBeer = new Tuple<string, int>
            {
                item1 = nameAndLitresBeer[0],
                item2 = int.Parse(nameAndLitresBeer[1])
            };

            Tuple<int, double> intAndDouble2 = new Tuple<int, double>
            {
                item1 = int.Parse(intAndDouble[0]),
                item2 = double.Parse(intAndDouble[1])
            };

            Console.WriteLine(nameAndAddres);
            Console.WriteLine(nameAndBeer);
            Console.WriteLine(intAndDouble2);

        }
    }
}
