using System;
using System.Collections.Generic;

namespace Custom_Doubly_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.AddLast(5);
            linkedList.AddLast(45);
            linkedList.AddLast(5456);
            linkedList.AddLast(53);
            linkedList.AddLast(3);
            linkedList.AddLast(2);

            foreach (var idk in linkedList)
            {
                Console.WriteLine(idk);
            }
        }
    }
}
