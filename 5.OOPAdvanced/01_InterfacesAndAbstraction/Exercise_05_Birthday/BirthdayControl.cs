using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_05_Birthday
{
    //Stores a list of all the entities and sorts them by birth date.
    public class BirthdayControl
    {
        private List<IBorn> born;
        private List<ICreated> robots;

        public List<IBorn> Born
        {
            get
            {
                return this.born;
            }
            private set
            {
                this.born = value;
            }
        }

        public List<ICreated> Robots
        {
            get
            {
                return this.robots;
            }
            private set
            {
                this.robots = value;
            }
        }

        public void addEntities(string traffic)
        {
            var entity = traffic.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var type = entity[0];
            var name = entity[1];

            if (type.Equals("Citizen"))
            {
                var age = int.Parse(entity[2]);
                var id = entity[3];
                var birthDate = entity[4];
                IBorn citizen = new Citizen(name, id, age, birthDate);
                this.Born.Add(citizen);
            }
            else if (type.Equals("Robot"))
            {
                var id = entity[2];
                ICreated robot = new Robot(name, id);
                this.Robots.Add(robot);
            }
            else if (type.Equals("Pet"))
            {
                var birthday = entity[2];
                IBorn pet = new Pet(birthday, name);
                this.Born.Add(pet);
            }
        }

        public BirthdayControl()
        {
            this.Born = new List<IBorn>();
            this.Robots = new List<ICreated>();
        }

        public string CheckBirthay(string birthYear)
        {
            var output = string.Empty;

            foreach (var person in this.Born.Where(y => y.BirthDate.EndsWith(birthYear)))
            {
                output += person.BirthDate + Environment.NewLine;
            }

            return output;
        }
    }
}