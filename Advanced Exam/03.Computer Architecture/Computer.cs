using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Linq;

namespace ComputerArchitecture
{
    public class Computer
    {
        public Computer(string model, int capacity)
        {
            this.Model = model;
            this.Capacity = capacity;
            this.Multiprocessor = new List<CPU>();
        }
        public List<CPU> Multiprocessor;
        public string Model { get; set; }
        public int Capacity { get; set; }

        public int Count => Multiprocessor.Count;

        public void Add(CPU cpu)
        {
            if (Multiprocessor.Count < Capacity)
            {
                Multiprocessor.Add(cpu);
            }
        }
        public bool Remove(string brand)
        {
            if (Multiprocessor.Exists(x => x.Brand == brand))
            {
                CPU cpu = Multiprocessor.FirstOrDefault(s => s.Brand == brand);
                return Multiprocessor.Remove(cpu);
            }
            return false;
        }

        public CPU MostPowerful()
        {
            return Multiprocessor.OrderByDescending(x => x.Frequency).FirstOrDefault();
        }
        public CPU GetCPU(string brand)
        {
            if (Multiprocessor.Exists(x => x.Brand == brand))
            {
                CPU cpu = Multiprocessor.FirstOrDefault(s => s.Brand == brand);
                return cpu;
            }
            return null;
        }

        public string Report()
        {
            return $"CPUs in the Computer {Model}:{Environment.NewLine}{string.Join(Environment.NewLine, Multiprocessor)}";
        }
    }
}
