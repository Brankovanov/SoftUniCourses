using System.Collections.Generic;

namespace Exercise_08_Google
{
    //Creates a person object that holds information about the person's name, company, pokemon2, parents, children and automobile.
    public class Person
    {
        private string name;
        private Company company;
        private List<Pokemon> pokemon;
        private List<Parents> parent;
        private List<Children> children;
        private Car automobile;

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

        public List<Pokemon> Pokemon
        {
            get
            {
                return this.pokemon;
            }
            set
            {
                this.pokemon = value;
            }
        }

        public List<Parents> Parent
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

        public List<Children> Children
        {
            get
            {
                return this.children;
            }
            set
            {
                this.children = value;

            }
        }

        public Car Automobile
        {
            get
            {
                return this.automobile;
            }
            set
            {
                this.automobile = value;
            }
        }

        public Person(string name)
        {
            this.name = name;
        }
    }
}