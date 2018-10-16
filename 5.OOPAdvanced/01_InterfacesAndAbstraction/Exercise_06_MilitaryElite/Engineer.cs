using System;
using System.Collections.Generic;

namespace Exercise_06_MilitaryElite
{
    //Engineer class derived by the IEngineer 
    public class Engineer : IEngineer
    {
        private List<Repair> repairs;
        private string id;
        private string firstName;
        private string lastName;
        private string corps;
        private double salary;

        public double Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                this.salary = value;
            }
        }

        public List<Repair> Repairs
        {
            get
            {
                return this.repairs;
            }
            private set
            {
                this.repairs = value;
            }
        }

        public string Corps
        {
            get
            {
                return this.corps;
            }
            private set
            {
                if (value == "Airforces" || value == "Marines")
                {
                    this.corps = value;
                }
                else
                {
                    return;
                }
            }
        }

        public string Id
        {
            get
            {
                return this.id;
            }
            private set
            {
                this.id = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
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
                this.lastName = value;
            }
        }


        public Engineer(string corps, string id, string firstName, string lastName, double salary)
        {
            this.Corps = corps;
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Repairs = new List<Repair>();
            this.Salary = salary;
        }

        public override string ToString()
        {
            if (this.corps != null)
            {
                var output = $"Name: {this.firstName} {this.lastName} Id: {this.id} Salary: {string.Format("{0:0.00}", this.salary)}{Environment.NewLine}" +
                      $"Corps: {this.corps}{Environment.NewLine}" +
                      $"Repairs: ";

                foreach (var repair in this.repairs)
                {
                    output += Environment.NewLine + repair.ToString();
                }

                return output.Remove(output.Length - 1, 1);
            }

            return null;
        }
    }
}