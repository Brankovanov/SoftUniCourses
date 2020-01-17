using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_02_Cars
{
    public class Tesla:ICar,IElectricCar
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
      

        public void Start()
        {
            Console.WriteLine("Engine start!");
        }

        public void Stop()
        {
            Console.WriteLine("Break!");
        }

        public Tesla(string model, string color, int battery)
        {
            this.Model = model;
            this.Color = color;
            this.Battery = battery;

        }
    }
}
