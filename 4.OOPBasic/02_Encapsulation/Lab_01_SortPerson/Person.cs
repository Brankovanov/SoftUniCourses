using System;

namespace Lab_01_SortPerson
{
    //Creates a person object that holds the person's names, age and salary.
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (value.Length >= 3)
                {
                    this.firstName = value;
                }
                else
                {
                    throw new ArgumentException("First name cannot be less than 3 symbols");
                }
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (value.Length >= 3)
                {
                    this.lastName = value;
                }
                else
                {
                    throw new ArgumentException("Last name cannot be less than 3 symbols");
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
                    throw new ArgumentException("Age cannot be zero or negative integer");
                }
            }
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                if (value >= 460)
                {
                    this.salary = value;
                }
                else
                {
                    throw new ArgumentException("Salary cannot be less than 460 leva");
                }
            }
        }

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public override string ToString()
        {
            return $"{this.firstName} {this.lastName} receives {string.Format("{0:0.00}", this.salary)} leva.";
        }
    }
}