using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerArchitecture
{
    public class Computer
    {
        private List<CPU> multiprocessor;
        public Computer(string model, int capacity)
        {
            multiprocessor = new List<CPU>();
            Model = model;
            Capacity = capacity;
        }

        public string Model { get; set; }
        public int Capacity { get; set; }

        public int Count
        {
            get { return multiprocessor.Count; }
        }

        public void Add(CPU cpu)
        {
            if (multiprocessor.Count < Capacity)
            {
                multiprocessor.Add(cpu);
            }
            else
            {
                return;
            }
        }
        public bool Remove(string brand)
        {
            if (!multiprocessor.Exists(x => x.Brand == brand))
            {
                return false;
            }

            return multiprocessor.Remove(multiprocessor.Find(x => x.Brand == brand));

        }

        public CPU MostPowerful()
        {
            return multiprocessor.OrderByDescending(x => x.Frequency).First();
        }
        public CPU GetCPU(string brand)
        {
            return multiprocessor.FirstOrDefault(x => x.Brand == brand);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"CPUs in the Computer {Model}:");
            foreach (var item in multiprocessor)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().Trim();
            // TrimEnd !
        }
    }
}
