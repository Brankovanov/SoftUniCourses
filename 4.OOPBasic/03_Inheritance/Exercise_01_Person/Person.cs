using System;
using System.Text;

namespace Exercise_01_Person
{
    //Creates a parent object person that holds the person's name and age.
    public class Person
    {
        private string name;
        private int age;

        public virtual string Name
        {
            get
            {
                return this.name;
            }
            set
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
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format("Name: {0}, Age: {1}", this.Name, this.Age));

            return stringBuilder.ToString();
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}