namespace Part_01_NeedForSpeed
{
    //Child class to the parent class car.
    public class ShowCar : Car
    {
        private int stars;

        public int Stars
        {
            get
            {
                return this.stars;
            }
            set
            {
                this.stars = value;
            }
        }

        public ShowCar(string brand, string model, int yearOfProduction, int horsePower, int acceleration, int suspension, int durability, int id, string type)
        : base(brand, model, yearOfProduction, horsePower, acceleration, suspension, durability, id, type)
        {
            this.Stars = stars;
        }

        public override string ToString()
        {
            return this.Stars.ToString();
        }

        public override void Tune(int index, string addons)
        {
            this.HorsePower = this.HorsePower + index;
            this.Suspension = this.Suspension + (index / 2);
            this.Stars = this.Stars + index;
        }
    }
}