using System;

namespace Exercise_04_SpeedRacing
{
    //Creates car object that holds the cars' model, fuel tank, fuel consumption per kilometer and the distance travelled.
    public class Car
    {
        private string model;
        private double fuelTank;
        private double fuelConsumption;
        private int distanceTraveled;

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                this.model = value;
            }
        }

        public double FuelTank
        {
            get
            {
                return this.fuelTank;
            }
            set
            {
                this.fuelTank = value;
            }
        }

        public double FuelConsumption
        {
            get
            {
                return this.fuelConsumption;
            }
            private set
            {
                this.fuelConsumption = value;
            }
        }

        public int DistanceTraveled
        {
            get
            {
                return this.distanceTraveled;
            }
            set
            {
                this.distanceTraveled = value;
            }
        }

        public Car(string model, int fuelTank, double fuelConsumtion)
        {
            this.model = model;
            this.fuelTank = fuelTank;
            this.fuelConsumption = fuelConsumtion;
            this.distanceTraveled = 0;
        }

        public void Travel(double fuelTank, double fuelConsumption, int distanceTraveled, int rout)
        {
            if (fuelTank - (rout * fuelConsumption) >= 0)
            {
                FuelTank -= rout * fuelConsumption;
                DistanceTraveled += rout;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}