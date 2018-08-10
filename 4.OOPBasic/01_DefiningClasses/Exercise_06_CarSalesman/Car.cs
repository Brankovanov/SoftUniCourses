namespace Exercise_06_CarSalesman
{
    //Creates a car object that holds the car model, engine information, weight, color.
    public class Car
    {
        private string model;
        private Engine engineType;
        private int weight = 0;
        private string color = "n/a";

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

        public Engine EngineType
        {
            get
            {
                return this.engineType;
            }
            set
            {
                this.engineType = value;
            }
        }

        public int Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                this.weight = value;
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

        public Car(string model, Engine engineType, int weight, string color)
        {
            this.model = model;
            this.engineType = engineType;
            this.weight = weight;
            this.color = color;
        }

        public Car(string model, Engine engineType, int weight)
        {
            this.model = model;
            this.engineType = engineType;
            this.weight = weight;
        }

        public Car(string model, Engine engineType, string color)
        {
            this.model = model;
            this.engineType = engineType;
            this.color = color;
        }

        public Car(string model, Engine engineType)
        {
            this.model = model;
            this.engineType = engineType;
        }
    }
}