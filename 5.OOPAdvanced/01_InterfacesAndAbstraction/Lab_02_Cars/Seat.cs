namespace Lab_02_Cars
{
    //Seat class derived from ICar interface. It holds Seat's model, color.
    public class Seat : ICar
    {
        private string model;
        private string color;

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
            return $"{this.Color} Seat {this.model}";
        }

        public Seat(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }
    }
}