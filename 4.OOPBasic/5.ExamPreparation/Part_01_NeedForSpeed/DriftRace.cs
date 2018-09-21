namespace Part_01_NeedForSpeed
{
    //Child class to the parent class race.
    public class DriftRace : Race
    {
        public DriftRace(int legth, string route, int prizePool, int id)
          : base(legth, route, prizePool, id)
        {
        }

        public override string CalulatePoints(Car car)
        {
            var points = (car.Suspension + car.Durability);
            return points.ToString();
        }
    }
}