using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_04_BorderControl_
{
    //Holds the traffic that goes through the border control, also checks the id's and detains the fake ones.
    public class BorderControl
    {
        private List<IEntity> traffic;
        private List<IEntity> detained;

        public List<IEntity> Traffic
        {
            get
            {
                return this.traffic;
            }
            private set
            {
                this.traffic = value;
            }
        }

        public List<IEntity> Detained
        {
            get
            {
                return this.detained;
            }
            private set
            {
                this.detained = value;
            }
        }

        public void addTraffic(string traffic)
        {
            var entity = traffic.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var name = entity[0];

            if (entity.Length == 3)
            {
                var age = int.Parse(entity[1]);
                var id = entity[2];
                IEntity citizen = new Citizen(name, id, age);
                this.Traffic.Add(citizen);
            }
            else
            {
                var id = entity[1];
                IEntity robot = new Robot(name, id);
                this.Traffic.Add(robot);
            }
        }

        public BorderControl()
        {
            this.Traffic = new List<IEntity>();
            this.Detained = new List<IEntity>();
        }

        public string CheckId(string fakeId)
        {
            this.Detained.AddRange(this.Traffic.Where(t => t.Id.EndsWith(fakeId)));
            this.Traffic.RemoveAll(t => t.Id.EndsWith(fakeId));
            var output = string.Empty;

            foreach (var person in this.Detained)
            {
                output += person.Id + Environment.NewLine;
            }

            return output;
        }
    }
}