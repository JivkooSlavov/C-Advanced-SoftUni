using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefeningClasses
{
    public class Engine
    {
        private string model;
        private int power;
        private int displacement;
        private string efficiency;
        public Engine()
        {
            
        }
        public Engine(string model, int power, int displacement, string efficiency) 
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = efficiency;

        }
       public Engine(string model, int power, int displacement)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            efficiency = null;
        }
        public Engine(string model, int power, string efficiency)
        {
            Model = model;
            Power = power;
            Efficiency = efficiency;
            Displacement = 0;
        }
        public Engine(string model, int power)
        {
            Model = model;
            Power = power;
            Efficiency = null;
            Displacement = 0;
        }

        public string Model{get; set;}
        public int Power{get; set;}
        public int Displacement{ get; set; }
        public string Efficiency{ get; set; }

    }
}
