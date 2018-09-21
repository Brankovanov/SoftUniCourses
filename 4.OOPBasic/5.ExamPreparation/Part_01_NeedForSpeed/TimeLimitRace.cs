namespace Part_01_NeedForSpeed
{
    //Child class to the parent class race.
    public class TimeLimitRace:Race
    {
        private int goldTime;
        private int numberOfParticipants;

        public int GoldTime
        {
            get
            {
                return this.goldTime;
            }
            set
            {
                this.goldTime = value;
            }
        }

        public int NumberOfParticipants
        {
            get
            {
                return this.numberOfParticipants;
            }
            set
            {
                if (numberOfParticipants < 1)
                {
                    this.numberOfParticipants = value;
                }
            }
        }

        public TimeLimitRace(int legth, string route, int prizePool, int id,int goldTime)
           : base(legth, route, prizePool, id)
        {
            this.GoldTime = goldTime;
            this.NumberOfParticipants = 0;
        }

        public override string CalulatePoints(Car car)
        {
            var points = 0;
            var time = this.Length * ((car.HorsePower / 100) * car.Acceleration);
            
            if(time<=this.GoldTime)
            {
                points = this.PrizePool;
            }
            else if (time<=this.GoldTime+15)
            {
                points = this.PrizePool / 2;
            }
            else if(time > this.GoldTime+15)
            {
                points = this.PrizePool * (30/100);
            }

            return time.ToString() + " s. " + "$" +points;
        }
    }
}