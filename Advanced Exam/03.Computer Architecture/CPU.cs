﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ComputerArchitecture
{
    public class CPU
    {
        public CPU(string brand, int cores, double frequency)
        {
            Brand = brand;
            Cores = cores;
            Frequency = frequency;
        }
        public string Brand  { get; set; }
        public int Cores  { get; set; }
        public double Frequency  { get; set; }
        public override string ToString()
        {
            return $"{Brand} CPU:" + Environment.NewLine +
                   $"Cores: {Cores}" + Environment.NewLine +
                   $"Frequency: {Frequency:F1} GHz";
        }
    }
}
