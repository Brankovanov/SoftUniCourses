namespace Part_2_Avatar
{
    //Child class to the class bender. Holds one additional property.
    public class FireBender : Bender
    {
        private float heatAggression;

        public float HeatAggression
        {
            get
            {
                return this.heatAggression;
            }
            set
            {
                this.heatAggression = value;
            }
        }

        public FireBender(string name, int power, float heatAggression)
            : base(name, power)
        {
            this.HeatAggression = heatAggression;
        }
    }
}