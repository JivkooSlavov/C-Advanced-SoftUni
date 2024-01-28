using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var allTrainers = new Dictionary<string, Trainer>();
            string command = "";
            while ((command=Console.ReadLine())!= "Tournament")
            {
                string[] data = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string trainerName = data[0];
                string pokemonName = data[1];
                string pokemonElement = data[2];
                int pokemonHealth = int.Parse(data[3]);

                Pokemon currentPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (!allTrainers.ContainsKey(trainerName))
                {
                    Trainer newTrainer = new Trainer(trainerName);
                    allTrainers.Add(trainerName, newTrainer);
                }
                Trainer trainer = allTrainers[trainerName];
                trainer.Pokemons.Add(currentPokemon);
            }

            string newCommand = "";
            while ((newCommand = Console.ReadLine()) != "End")
            {
                foreach (var trainer in allTrainers)
                {
                    if (trainer.Value.Pokemons.Any(x => x.Element == newCommand))
                    {
                        trainer.Value.NumberOfBadges += 1;
                    }
                    else
                    {
                        foreach (var pokemon in trainer.Value.Pokemons)
                        {
                            pokemon.Health -= 10;
                        }
                        trainer.Value.Pokemons.RemoveAll(x => x.Health <= 0);
                    }
                }
            }
            foreach (var trainer in allTrainers.OrderByDescending(x=>x.Value.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Key} {trainer.Value.NumberOfBadges} {trainer.Value.Pokemons.Count}");
            }
        }
    }
}
