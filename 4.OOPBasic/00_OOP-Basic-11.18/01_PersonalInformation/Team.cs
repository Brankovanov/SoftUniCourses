using System;
using System.Collections.Generic;

namespace _01_PersonalInformation
{
    public class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public List<Person> ReserveTeam
        {
            get
            {
                return this.reserveTeam;
            }
            set
            {
                this.reserveTeam = value;
            }
        }

        public List<Person> FirstTeam
        {
            get
            {
                return this.firstTeam;
            }
            set
            {
                this.firstTeam = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public Team(string name)
        {
            this.Name = name;
            this.FirstTeam = new List<Person>();
            this.ReserveTeam = new List<Person>();
        }

        public void AddPlayers(Person person)
        {
            if (person.Age < 40)
            {
                this.FirstTeam.Add(person);
            }
            else
            {
                this.reserveTeam.Add(person);
            }
        }

        public override string ToString()
        {
            return $"First team has {this.FirstTeam.Count} players. "
                + Environment.NewLine +
                $"Reserve team has {this.ReserveTeam.Count} players.";
        }
    }
}