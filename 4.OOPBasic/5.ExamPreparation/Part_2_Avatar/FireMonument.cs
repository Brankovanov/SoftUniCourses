namespace Part_2_Avatar
{
    //Child class to the class monument. Holds one additional property.
    public class FireMonument : Monument
    {
        private int fireAffinity;

        public int FireAffinity
        {
            get
            {
                return this.fireAffinity;
            }
            set
            {
                this.fireAffinity = value;
            }
        }

        public FireMonument(string name, int fireAffinity)
            : base(name)
        {
            this.FireAffinity = fireAffinity;
        }
    }
}