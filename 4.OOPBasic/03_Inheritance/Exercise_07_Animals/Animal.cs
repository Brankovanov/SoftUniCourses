using System;

namespace Exercise_07_Animals
{
    //Parent class that holds the animal's name, age, gender and speciec.
    public class Animal
    {
        private string name;
        private int age;
        private string gender;
        private string kind;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid input!");
                }
                else
                {
                    this.name = value;
                }
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
                if (!int.TryParse(value.ToString(), out int a) || value < 0)
                {
                    throw new ArgumentException("Invalid input!");
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public virtual string Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid input!");
                }
                else
                {
                    this.gender = value;
                }
            }
        }

        public string Kind
        {
            get
            {
                return this.kind;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid input!");
                }
                else
                {
                    this.kind = value;
                }
            }
        }

        public Animal(string name, int age, string gender, string kind)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Kind = kind;
        }

        public virtual string ProduceSound()
        {
            return "Not implemented!";
        }
    }
}