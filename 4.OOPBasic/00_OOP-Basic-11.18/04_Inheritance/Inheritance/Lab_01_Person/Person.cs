using System;

namespace Lab_01_Person
{
    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                if (value.Length >= 3)
                {

                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Name's length should not be less than 3 symbols!");
                }
            }
        }

        public virtual int Age
        {
            get
            {
                return this.age;
            }
            protected set
            {
                if (value > 0)
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentException("Age must be positive.");
                }
            }
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}";
        }
    }
}
