using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> redo = new Stack<string>();
            Stack<string> undo = new Stack<string>();
            undo.Push(String.Empty);
            StringBuilder text = new StringBuilder();
            int N = int.Parse(Console.ReadLine());


            for (int i = 0; i < N; i++)
            {
                string[] commandArguments = Console.ReadLine().Split();
                string cmndType = commandArguments[0];

                switch (cmndType)
                {
                    case "1":
                        text.Append(commandArguments[1]);
                        undo.Push(text.ToString());
                        break;
                    case "2":
                        int charsToRemove = int.Parse(commandArguments[1]);
                        text = text.Remove(text.Length - charsToRemove, charsToRemove);
                        undo.Push(text.ToString());
                        break;
                    case "3":
                        int indexToFind = int.Parse(commandArguments[1]);
                        if (indexToFind >= 0 && indexToFind <= text.Length)
                        {
                        Console.WriteLine(text[indexToFind - 1]);
                        }
                        break;
                    case "4":
                        var item = undo.Pop();
                        redo.Push(item);
                        string previousVersion = undo.Peek();
                        text = new StringBuilder(previousVersion);
                        Console.WriteLine(text);
                        break;
                    case "5":
                        string afterVersion = redo.Peek();
                        text = new StringBuilder(afterVersion);
                        Console.WriteLine(text);
                        break;
                }
            }
        }
    }
}
