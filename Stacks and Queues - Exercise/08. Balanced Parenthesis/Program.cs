using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string parentheses = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            foreach (var chary in parentheses)
            {
                if (stack.Any())
                {
                    char check = stack.Peek();
                    if (check == '{' && chary == '}')
                    {
                        stack.Pop();
                        continue;
                    }
                    else if (check == '[' && chary == ']')
                    {
                        stack.Pop();
                        continue;
                    }
                    else if (check == '(' && chary == ')')
                    {
                        stack.Pop();
                        continue;
                    }
                }
                stack.Push(chary);
            }

            if (stack.Any())
            {
                Console.WriteLine("NO");
                return;
            }
            else
            {
                Console.WriteLine("YES");
                return;
            }
            //Console.WriteLine(!stack.Any() ? "YES" : "NO");
        }
    }
}
