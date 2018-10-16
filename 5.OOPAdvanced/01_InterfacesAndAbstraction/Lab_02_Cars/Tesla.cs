namespace Lab_02_Cars
{
    //Tesla class derived from ICar and IElecicCar interfaces. It holds Tesla's model, color, battery.
    public class Tesla : ICar, IElectricCar
    {
        private string model;
        private string color;
        private int battery;

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

        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }

        public int Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            return $"{this.Color} Tesla {this.model} with {this.Battery} Batteries";
        }

        public Tesla(string model, string color, int battery)
        {
            this.Model = model;
            this.Color = color;
            this.Battery = battery;
        }
    }
}