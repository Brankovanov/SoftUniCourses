using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_06_MilitaryElite
{

    //Commando class derived by ICommando interface. Hplds the commando characerisrics
    public class Commando : ICommando
    {
        private string corps;
        private string id;
        private string firstName;
        private string lastName;
        private List<Mission> missions;
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

        public List<Mission> Missions
        {
            get
            {
                return this.missions;
            }
            private set
            {
                this.missions = value;
            }
        }

        public Commando(string corps, string id, string firstName, string lastName, double salary)
        {
            this.Corps = corps;
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Missions = new List<Mission>();
            this.Salary = salary;
        }

        public override string ToString()
        {
            if (this.corps != null)
            {
                var output = $"Name: {this.firstName} {this.lastName} Id: {this.id} Salary: {string.Format("{0:0.00}", this.salary)}{Environment.NewLine}" +
                   $"Corps: {this.corps}{Environment.NewLine}" +
                   $"Missions: ";

                foreach (var mission in missions.Where(m => m.State != null))
                {
                    output += Environment.NewLine + "  " + mission.ToString();
                }

                return output.Remove(output.Length - 1, 1);
            }
            return null;
        }
    }
}