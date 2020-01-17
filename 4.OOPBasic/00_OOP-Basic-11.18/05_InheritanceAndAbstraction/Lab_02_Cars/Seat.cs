

using System;

namespace Lab_02_Cars
{
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

        public void Start()
        {
            Console.WriteLine("Engine start!");
        }

        public void Stop()
        {
            Console.WriteLine("Break!");
        }

        public Seat(string model, string color)
        {
            this.Model = model;
            this.Color = color;

        }
    }
}
