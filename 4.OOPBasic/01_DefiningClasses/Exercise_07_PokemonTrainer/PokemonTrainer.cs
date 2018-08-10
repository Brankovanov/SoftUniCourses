using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_07_PokemonTrainer
{
    public class PokemonTrainer
    {
        public static void Main()
        {
            ReceiveInput();
        }

        //Receives pokemon and trainer information.
        public static void ReceiveInput()
        {
            var listOfTrainers = new List<Trainer>();
            var command = Console.ReadLine();

            while (command != "Tournament")
            {
                var temp = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var trainerName = temp[0];
                var pokemonName = temp[1];
                var pokemonElement = temp[2];
                var pokemonHealth = int.Parse(temp[3]);
                var newPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (listOfTrainers.Exists(t => t.Name == trainerName))
                {
                    listOfTrainers.Find(t => t.Name == trainerName).Pokemons.Add(newPokemon);
                }
                else
                {
                    var newTrainer = new Trainer(trainerName, new List<Pokemon>());
                    listOfTrainers.Add(newTrainer);
                    listOfTrainers.Find(t => t.Name == trainerName).Pokemons.Add(newPokemon);
                }

                command = Console.ReadLine();
            }

            ReceiveBattles(listOfTrainers);
        }

        //Receives battle parameters from the console.
        public static void ReceiveBattles(List<Trainer> listOfTrainers)
        {
            var parameter = Console.ReadLine();

            while (parameter != "End")
            {
                ResolveBattle(parameter, listOfTrainers);
                parameter = Console.ReadLine();
            }

            PrintResult(listOfTrainers);
        }

        //Resolves the battle.
        public static void ResolveBattle(string parameter, List<Trainer> listOfTrainers)
        {
            for (var trainer = 0; trainer < listOfTrainers.Count; trainer++)
            {
                if (listOfTrainers[trainer].Pokemons.Exists(p => p.Element == parameter))
                {
                    listOfTrainers[trainer].NumberOfBadges++;
                }
                else
                {
                    listOfTrainers[trainer].Pokemons.ForEach(p => p.Health = p.Health - 10);
                    listOfTrainers[trainer].Pokemons.RemoveAll(pok => pok.Health <= 0);
                }
            }
        }

        //Prints the results from all the battles.
        public static void PrintResult(List<Trainer> listOfTrainers)
        {
            foreach (var trainer in listOfTrainers.OrderByDescending(b => b.NumberOfBadges))
            {
                Console.WriteLine(string.Join(" ", trainer.Name, trainer.NumberOfBadges, trainer.Pokemons.Count));
            }
        }
    }
}