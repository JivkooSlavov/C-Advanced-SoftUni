using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Trainer
    {
        private string name;
        private int numberOfBadges;
        private List<Pokemon> pokemons;


        public string Name { get; set; }
        public int NumberOfBadges { get;set; }
        public List<Pokemon> Pokemons { get; set; }

        public Trainer(string name)
        {
            Name = name;
            NumberOfBadges = 0;
            Pokemons = new List<Pokemon>();
        }
    }
}
