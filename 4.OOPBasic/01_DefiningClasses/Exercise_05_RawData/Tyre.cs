namespace Exercise_05_RawData
{
    //Creates a tyre object that holds the tyre's age and pressure.
    public class Tyre
    {
        private int age;
        private double pressure;

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public double Pressure
        {
            get
            {
                return this.pressure;
            }
            set
            {
                this.pressure = value;
            }
        }

        public Tyre(int age, double pressure)
        {
            this.age = age;
            this.pressure = pressure;
        }
    }
}