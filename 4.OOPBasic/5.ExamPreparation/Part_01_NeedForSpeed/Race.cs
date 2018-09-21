using System.Collections.Generic;

namespace Part_01_NeedForSpeed
{
    //Parent class race.
    public class Race
    {
        private int length;
        private string route;
        private int prizePool;
        private Dictionary<Car, string> particisants;
        private int id;

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public int Length
        {
            get
            {
                return this.length;
            }
            set
            {
                this.length = value;
            }
        }

        public string Route
        {
            get
            {
                return this.route;
            }
            set
            {
                this.route = value;
            }
        }

        public int PrizePool
        {
            get
            {
                return this.prizePool;
            }
            set
            {
                this.prizePool = value;
            }
        }

        public Dictionary<Car, string> Participants
        {
            get
            {
                return this.particisants;
            }
            set
            {
                this.particisants = value;
            }
        }

        public Race(int legth, string route, int prizePool, int id)
        {
            this.Id = id;
            this.Length = legth;
            this.Route = route;
            this.PrizePool = prizePool;
            this.Participants = new Dictionary<Car, string>();
        }

        public virtual string CalulatePoints(Car car)
        {
            var points = (car.HorsePower / car.Acceleration) + (car.Suspension + car.Durability);
            return points.ToString();
        }
    }
}