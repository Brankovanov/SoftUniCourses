namespace Part_2_Avatar
{
    //Child class to the class monument. Holds one additional property.
    public class WaterMonument : Monument
    {
        private int waterAffinity;

        public int WaterAffinity
        {
            get
            {
                return this.waterAffinity;
            }
            set
            {
                this.waterAffinity = value;
            }
        }

        public WaterMonument(string name, int waterAffinity)
            : base(name)
        {
            this.WaterAffinity = waterAffinity;
        }
    }
}