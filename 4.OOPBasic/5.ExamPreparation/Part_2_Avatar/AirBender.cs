namespace Part_2_Avatar
{
    //Child class to the class bender. Holds one additional property.
    public class AirBender : Bender
    {
        private float aerialIntegrity;

        public float AerialIntegrity
        {
            get
            {
                return this.aerialIntegrity;
            }
            set
            {
                this.aerialIntegrity = value;
            }
        }

        public AirBender(string name, int power, float aerialIntegrity)
            : base(name, power)
        {
            this.AerialIntegrity = aerialIntegrity;
        }
    }
}