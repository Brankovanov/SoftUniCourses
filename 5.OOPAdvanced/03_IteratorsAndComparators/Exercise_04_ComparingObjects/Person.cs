using System;
using System.Collections.Generic;

namespace Exercise_04_ComparingObjects
{
    //Person object holding the person's name, age and town.
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;
        private string town;

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

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public string Town
        {
            get
            {
                return this.town;
            }
            set
            {
                this.town = value;
            }
        }

        public Person(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }

        public int CompareTo(Person person)
        {    
            if (this.Name == person.name)
            {
                if (this.Age == person.age)
                {
                    if (this.Town == person.town)
                    {
                        return 1;
                    }
                }
            }
           
                return 0;
        }
    }
}