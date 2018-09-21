namespace Part_2_Avatar
{
    //Child class to the class monument. Holds one additional property.
    public class EarthMonument : Monument
    {
        private int earthAffinity;

        public int EarthAffinity
        {
            get
            {
                return this.earthAffinity;
            }
            set
            {
                this.earthAffinity = value;
            }
        }

        public EarthMonument(string name, int earthAffinity)
            : base(name)
        {
            this.EarthAffinity = earthAffinity;
        }
    }
}