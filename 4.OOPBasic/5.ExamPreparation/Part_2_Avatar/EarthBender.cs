namespace Part_2_Avatar
{
    //Child class to the class bender. Holds one additional property.
    public class EarthBender : Bender
    {
        private float groundSaturation;

        public float GroundSaturation
        {
            get
            {
                return this.groundSaturation;
            }
            set
            {
                this.groundSaturation = value;
            }
        }

        public EarthBender(string name, int power, float groundSaturation)
            : base(name, power)
        {
            this.GroundSaturation = groundSaturation;
        }
    }
}