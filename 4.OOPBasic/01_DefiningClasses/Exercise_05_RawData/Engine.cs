namespace Exercise_05_RawData
{
    //Creates an engine object that holds the engine's speed and power.
    public class Engine
    {
        private int speed;
        private int power;

        public int Speed
        {
            get
            {
                return this.speed;
            }
            set
            {
                this.speed = value;
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

        public Engine(int speed, int power)
        {
            this.speed = speed;
            this.power = power;
        }
    }
}