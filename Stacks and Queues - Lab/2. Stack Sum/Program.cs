using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split()
                .Select(int.Parse).ToList());

            var command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                var splitted = command.Split();
                switch (splitted[0])
                {
                    case "add":
                        int firstNum = (int.Parse(splitted[1]));
                        int secondNum = (int.Parse(splitted[2]));
                        stack.Push(firstNum);
                        stack.Push(secondNum);
                        break;
                    case "remove":
                        int theCount = int.Parse(splitted[1]);
                        if (theCount <= stack.Count )
                        {

                        for (int i = 0; i < theCount; i++)
                        {
                            stack.Pop();
                        }
                            
                        }

                        break;
                }
                        command = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
