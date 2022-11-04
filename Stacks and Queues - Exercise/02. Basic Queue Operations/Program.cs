using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
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

            Queue<int> que = new Queue<int>(intsToAdd);

            for (int i = 0; i < removeCount; i++)
            {
                que.Dequeue();
            }
            if (que.Contains(toLook))
            {
                Console.WriteLine("true");
            }
            else if (que.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(que.Min());
            }
        }
    }
}
