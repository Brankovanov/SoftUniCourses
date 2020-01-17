using System;

namespace _01_PersonalInformation
{
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
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }

                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }

                this.age = value;
            }
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            private set
            {
                if (salary < 460)
                {
                    throw new ArgumentException("Salary cannot be less than 460 leva!");
                }

                this.salary = value;
            }
        }

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            try
            {
                this.FirstName = firstName;
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Age = age;
                this.Salary = salary;
            }
            catch (ArgumentException err)
            {
                Console.WriteLine(err.Message);
            }
        }

        public decimal IncreaseSalary(decimal bonus)
        {
            if (this.Age <= 30)
            {
                return this.Salary += this.Salary * ((bonus / 2) / 100);
            }
            else
            {
                return this.Salary += this.Salary * ((bonus) / 100);
            }
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {string.Format(string.Format("{0:0.00}", this.Salary))} leva.";
        }
    }
}