using System.Text;
using System.Xml.Linq;
using System;

namespace FishingNet
{
    public class Fish
    {
        public Fish(string fishType, double lenght, double weight)
        {
            FishType = fishType;
            Length = lenght;
            Weight = weight;
        }
        public string FishType { get; set; }
        public double Length { get; set; }
        public double Weight { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"There is a {FishType}, {Length} cm. long, and {Weight} gr. in weight.");

            return sb.ToString().Trim();
        }
    }
}
