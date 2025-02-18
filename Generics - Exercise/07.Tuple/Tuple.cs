﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _07.Tuple
{
    public class Tuple<T1, T2>
    {
        public T1 item1 { get; set; }
        public T2 item2 { get; set; }
        public override string ToString()
        {
            return $"{item1} -> {item2}";
        }
    }
}
