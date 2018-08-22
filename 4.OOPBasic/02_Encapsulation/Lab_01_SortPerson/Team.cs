using System.Collections.Generic;

namespace Lab_01_SortPerson
{
    //Creates newTeam object that holds the teams name and first and reserved teams lists.
    public class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

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

        public IReadOnlyCollection<Person> FirstTeam
        {
            get
            {
                return this.firstTeam.AsReadOnly();
            }
        }

        public IReadOnlyCollection<Person> ReserveTeam
        {
            get
            {
                return this.reserveTeam.AsReadOnly();
            }
        }

        public Team(string name)
        {
            this.name = name;
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
        }

        public void AddPlayer(Person newPerson)
        {
            if (newPerson.Age < 40)
            {
                firstTeam.Add(newPerson);
            }
            else
            {
                reserveTeam.Add(newPerson);
            }
        }
    }
}