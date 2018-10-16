using System;
using System.Collections.Generic;

namespace Exercise_06_MilitaryElite
{
    //Class derived from the ILeutenantGeneral. Holds leutenant general's id, names, salary and the soldiers under his command.
    public class LeutenantGeneral : ILeutenantGeneral
    {
        private string id;
        private string firstName;
        private string lastName;
        private double salary;
        private List<ISoldier> privates;

        public double Salary
        {
            get
            {
                return this.salary;
            }
            private set
            {
                this.salary = value;
            }
        }

        public List<ISoldier> Privates
        {
            get
            {
                return this.privates;
            }
            private set
            {
                this.privates = value;
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

        public LeutenantGeneral(string id, string firstName, string lastName, double salary)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Privates = new List<ISoldier>();
            this.Salary = salary;
        }

        public override string ToString()
        {
            var output = $"Name: {this.firstName} {this.lastName} Id: {this.id} Salary: {string.Format("{0:0.00}", this.salary)}{Environment.NewLine}" +
                $"Privates: ";

            foreach (var priv in this.privates)
            {
                output += Environment.NewLine + "  " + priv.ToString();
            }

            return output.Remove(output.Length - 1, 1);
        }
    }
}