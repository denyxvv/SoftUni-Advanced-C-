﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _01.BoxOfString
{
    public class Box<T>
    {
        public Box()
        {
            Items = new List<T>();
        }

        public List<T> Items { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in Items)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }

            return sb.ToString().TrimEnd();
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            T temp = Items[firstIndex];
            Items[firstIndex] = Items[secondIndex];
            Items[secondIndex] = temp;
        }
    }
}