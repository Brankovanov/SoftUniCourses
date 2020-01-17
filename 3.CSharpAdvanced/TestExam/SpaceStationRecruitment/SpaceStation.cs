using System;
using System.Collections.Generic;
using System.Linq;

namespace SpaceStationRecruitment
{
    public class SpaceStation
    {
        private List<Astronaut> data;
        private string name;
        private int capacity;

        public List<Astronaut> Data
        {
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
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
        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            set
            {
                this.capacity = value;
            }
        }

        public int Count
        {
            get
            {
                return this.Data.Count;
            }
        }

        public void Add(Astronaut astronaut)
        {
            if (this.Data.Count < this.Capacity)
            {
                this.Data.Add(astronaut);
            }
        }

        public bool Remove(string name)
        {
            if (this.Data.Exists(a => a.Name == name))
            {
                this.Data.Remove(Data.Find(n => n.Name == name) as Astronaut);

                return true;
            }
            else
            {
                return false;
            }
        }

        public Astronaut GetOldestAstronaut()
        {
            var age = 0;
            Astronaut elderlySpaceMan = new Astronaut(string.Empty, 0, string.Empty) ;
            foreach (var spaceMan in this.Data.OrderBy(a => a.Age))
            {
                if (spaceMan.Age > age)
                {
                    age = spaceMan.Age;
                    elderlySpaceMan = spaceMan;
                }
            }

            return elderlySpaceMan;
        }

        public Astronaut GetAstronaut(string name)
        {
            
            return this.Data.Find(n => n.Name == name) as Astronaut;

        }

       

        public string Report()
        {
            var output = $"Astronauts working at Space Station {this.Name}:  {Environment.NewLine}";
            
            foreach(var astronaut in this.Data)
            {
                output += astronaut.ToString() + Environment.NewLine;
            }

            return output;
        }

        public SpaceStation(string name, int capacity)
        {
            this.Data = new List<Astronaut>();
            this.Name = name;
            this.Capacity = capacity;
        }
    }
}

