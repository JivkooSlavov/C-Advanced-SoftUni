using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DefeningClasses
{
    internal class Car
    {
        private string model;
        private string engine;
        private int weight;
        private string color;

        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
            Weight = 0;
            Color = null;
        }
        public Car(string model, Engine engine, int weight)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = null;
        }
        public Car(string model, Engine engine, string color)
        {
            Model = model;
            Engine = engine;
            Color = color;
            Weight = 0;
        }
        public Car(string model, Engine engine, int weight, string color)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }

        public string Model
        { get; set; }
        public Engine Engine
        { get; set; }
        public int Weight
        { get; set; }
        public string Color 
        {  get; set; }

       public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.Model}:");
            sb.AppendLine($"  {this.Engine.Model}:");
            sb.AppendLine($"    Power: {this.Engine.Power}");

            if (this.Engine.Displacement == 0)
            {
                sb.AppendLine("    Displacement: n/a");
            }

            else
            {
                sb.AppendLine($"    Displacement: {Engine.Displacement}");
            }
            if (this.Engine.Efficiency == null || Engine.Efficiency=="")
            {
                sb.AppendLine("    Efficiency: n/a");
            }
            else
            {
                sb.AppendLine($"    Efficiency: {Engine.Efficiency}");
            }
            if (this.Weight == 0)
            {
                sb.AppendLine("  Weight: n/a");
            }

            else
            {
                sb.AppendLine($"  Weight: {Weight}");
            }
            if (Color==null)
            {
                sb.AppendLine($"  Color: n/a");
            }
            else
            {
                sb.AppendLine($"  Color: {Color}");
            }

            return sb.ToString().Trim();
        }
    }
}
