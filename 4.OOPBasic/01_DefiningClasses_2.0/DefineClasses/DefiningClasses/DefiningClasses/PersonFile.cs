using System;

namespace DefiningClasses
{
    public class PersonFile
    {
        private Company company;
        private PersonCar car;
        private PokemonCollection pokemonArhive;
        private Parents parent;
        private Children child;

        public Children Child
        {
            get
            {
                return this.child;
            }
            set
            {
                this.child = value;
            }
        }
        
        public Parents Parent
        {
            get
            {
                return this.parent;
            }
            set
            {
                this.parent = value;
            }
        }

        public PokemonCollection PokemonArhive
        {
            get
            {
                return this.pokemonArhive;
            }
            set
            {
                this.pokemonArhive = value;
            }
        }

        public Company Company
        {
            get
            {
                return this.company;
            }
            set
            {
                this.company = value;
            }
        }

        public PersonCar Car
        {
            get
            {
                return this.car;
            }
            set
            {
                this.car = value;
            }
        }

        public PersonFile()
        {
            this.Company = new Company();
            this.Car = new PersonCar();
            this.PokemonArhive = new PokemonCollection();
            this.Parent = new Parents();
            this.Child = new Children();
        }

        public string Output(string name)
        {
            var output = name + Environment.NewLine
                + "Company:";

            if (this.Company != null)
            {
                output += this.Company.Output() + "Car:" ;
            }
            else
            {
                output += "Car:";
            }

            if (this.Car != null)
            {
                output += this.Car.Output() + "Pokemon:" ;
            }
            else
            {
                output += "Pokemon:";
            }

            if (this.PokemonArhive != null)
            {
                output += this.PokemonArhive.Output() + "Parents:" ;
            }
            else
            {
                output += "Parents:";
            }
               
            if(this.Parent!=null)
            {
                output += this.Parent.Output() + "Children:" ;
            }
            else
            {
                output += "Children:";
            }
                
            if(this.Child!=null)
            {
                output+= this.Child.Output() ;
            }
                

            return output;
               
        }
    }
}
