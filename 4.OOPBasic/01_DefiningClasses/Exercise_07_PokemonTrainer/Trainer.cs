using System.Collections.Generic;

namespace Exercise_07_PokemonTrainer
{
    //Creates a trainer object that holds the trainer's name, number of badges and a list of pokemons.
    public class Trainer
    {
        private string name;
        private int numberOfBadges = 0;
        private List<Pokemon> pokemons;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int NumberOfBadges
        {
            get
            {
                return this.numberOfBadges;
            }
            set
            {
                this.numberOfBadges = value;
            }
        }

        public List<Pokemon> Pokemons
        {
            get
            {
                return this.pokemons;
            }
            set
            {
                this.pokemons = value;
            }
        }

        public Trainer(string name, List<Pokemon> pokemons)
        {
            this.name = name;
            this.numberOfBadges = numberOfBadges;
            this.pokemons = pokemons;
        }
    }
}