namespace Exercise_06_CarSalesman
{
    //Creates an engine object the holds information about the engine's model, power, displacement and efficiency.
    public class Engine
    {
        private string model;
        private int power;
        private int displacement = 0;
        private string efficiency = "n/a";

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
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

        public int Displacement
        {
            get
            {
                return this.displacement;
            }
            set
            {
                this.displacement = value;
            }
        }

        public string Efficiency
        {
            get
            {
                return this.efficiency;
            }
            set
            {
                this.efficiency = value;
            }
        }

        public Engine(string model, int power, int displacement, string efficiency)
        {
            this.model = model;
            this.power = power;
            this.displacement = displacement;
            this.efficiency = efficiency;
        }

        public Engine(string model, int power, int displacement)
        {
            this.model = model;
            this.power = power;
            this.displacement = displacement;
        }

        public Engine(string model, int power, string efficiency)
        {
            this.model = model;
            this.power = power;
            this.efficiency = efficiency;
        }

        public Engine(string model, int power)
        {
            this.model = model;
            this.power = power;
        }
    }
}