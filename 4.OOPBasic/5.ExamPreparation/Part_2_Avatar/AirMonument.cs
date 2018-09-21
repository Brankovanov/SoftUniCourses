namespace Part_2_Avatar
{
    //Child class to the class monument. Holds one additional property.
    public class AirMonument : Monument
    {
        private int airAffinity;

        public int AirAffinity
        {
            get
            {
                return this.airAffinity;
            }
            set
            {
                this.airAffinity = value;
            }
        }

        public AirMonument(string name, int airAffinity)
            : base(name)
        {
            this.AirAffinity = airAffinity;
        }
    }
}