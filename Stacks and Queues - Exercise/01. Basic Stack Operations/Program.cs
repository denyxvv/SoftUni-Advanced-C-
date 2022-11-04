using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] stackArgs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = stackArgs[0];
            int removeCount = stackArgs[1];
            int toLook = stackArgs[2];

            int[] intsToAdd = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(intsToAdd);

            for (int i = 0; i < removeCount; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(toLook))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
