

using System;

namespace Lab_05_AnimalFarm
{
    public class Animal
    {
        private string name;
        private int age;
        private string gender;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value != string.Empty)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Invalid input!");
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
                if (value > 0)
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentException("Invalid input!");
                }
            }
        }

        public string Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                if (value != string.Empty)
                {
                    this.gender = value;
                }
                else
                {
                    throw new ArgumentException("Invalid input!");
                }
            }
        }

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.gender = gender;
        }

        public virtual string ProduceSound()
        {
            return string.Empty;
        }
    }
}
