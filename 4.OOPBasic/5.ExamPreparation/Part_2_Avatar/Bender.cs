namespace Part_2_Avatar
{
    //The base class bender. Holds the bender's power and name.
    public abstract class Bender
    {
        private string name;
        private int power;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Power
        {
            get
            {
                return this.power;
            }
            set
            {
                this.power = value;
            }
        }

        public Bender(string name, int power)
        {
            this.Name = name;
            this.Power = power;
        }
    }
}