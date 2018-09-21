namespace Part_01_NeedForSpeed
{
    //Child class to the parent class race.
    public class CircuitRace : Race
    {
        private int labs;

        public int Labs
        {
            get
            {
                return this.labs;
            }
            set
            {
                this.labs = value;
            }
        }

        public CircuitRace(int legth, string route, int prizePool, int id, int labs)
         : base(legth, route, prizePool, id)
        {
            this.Labs = labs;
        }

        public override string CalulatePoints(Car car)
        {
            var points = 0;

            for (var lab = 0; lab < this.Labs; lab++)
            {
                points += (car.HorsePower / car.Acceleration) + (car.Suspension + car.Durability);
                car.Durability = car.Durability - (this.Length * this.Length);
            }

            return points.ToString();
        }
    }
}