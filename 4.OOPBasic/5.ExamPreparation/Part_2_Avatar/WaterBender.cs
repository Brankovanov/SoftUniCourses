namespace Part_2_Avatar
{
    //Child class to the class bender. Holds one additional property.
    public class WaterBender : Bender
    {
        private float waterClarity;

        public float WaterClarity
        {
            get
            {
                return this.waterClarity;
            }
            set
            {
                this.waterClarity = value;
            }
        }

        public WaterBender(string name, int power, float waterClarity)
            : base(name, power)
        {
            this.WaterClarity = waterClarity;
        }
    }
}