namespace Exercise_08_Google
{
    //Creates a pokemon object that holds information about the pokemon's name and type.
    public class Pokemon
    {
        private string pokemonName;
        private string pokemonType;

        public string PokemonName
        {
            get
            {
                return this.pokemonName;
            }
            set
            {
                this.pokemonName = value;
            }
        }

        public string PokemonType
        {
            get
            {
                return this.pokemonType;
            }
            set
            {
                this.pokemonType = value;
            }
        }

        public Pokemon(string pokemonName, string pokemonType)
        {
            this.pokemonName = pokemonName;
            this.pokemonType = pokemonType;
        }
    }
}