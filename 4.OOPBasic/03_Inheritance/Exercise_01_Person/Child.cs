using System;

namespace Exercise_01_Person
{
    //Creates a derived object child that holds the childs name and age.
    public class Child : Person
    {
        public override int Age
        {
            get
            {
                return base.Age;
            }
            set
            {
                if (value > 15)
                {
                    throw new ArgumentException("Child's age must be less than 15!");
                }
                else
                {
                    base.Age = value;
                }
            }
        }

        public Child(string name, int age)
            : base(name, age)
        {
        }
    }
}