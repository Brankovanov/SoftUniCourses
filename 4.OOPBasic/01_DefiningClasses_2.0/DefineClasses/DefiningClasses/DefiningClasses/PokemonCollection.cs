using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class PokemonCollection
    {
        private Dictionary<string, string> pokemons;

        public Dictionary<string,string> Pokemons
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

        public string Output()
        {
            var output = string.Empty;

            foreach (var pokemon in this.Pokemons)
            {
                output += pokemon.Key + " " + pokemon.Value + Environment.NewLine;
            }

            output = Environment.NewLine + output;

            return output;
        }

        public PokemonCollection()
        {
            this.Pokemons = new Dictionary<string, string>();
        }
    }
}
