using System;

namespace Exercise_01__Vehicles
{
    //A parent class that holds the vehicles characteristics, also the possible actions that they can perform.
    public abstract class Vehicles
    {
        private double fuel;
        private double consumption;
        private double tankCapacity;
        private bool passanger;

        public bool Passanger
        {
            get
            {
                return this.passanger;
            }
            set
            {
                this.passanger = value;
            }
        }

        public double TankCapacity
        {
            get
            {
                return this.tankCapacity;
            }
            set
            {
                this.tankCapacity = value;
            }
        }

        public double Fuel
        {
            get
            {
                return this.fuel;
            }
            set
            {
                if (value > 0)
                {
                    this.fuel = value;
                }
                else
                {
                    throw new ArgumentException("Fuel must be a positive number");
                }
            }
        }

        public Vehicles(double fuel, double consumption, double tankCapacity, bool passenger)
        {
            this.Fuel = fuel;
            this.Consumption = consumption;
            this.TankCapacity = tankCapacity;
            this.Passanger = passenger;
        }

        public virtual double Consumption
        {
            get
            {
                return this.consumption;
            }
            set
            {
                this.consumption = value;
            }
        }

        public virtual string Drive(double distance)
        {
            return $" travelled {distance} km";
        }

        public virtual void Refuel(double quantityRefueld)
        {
            this.Fuel += quantityRefueld;
        }

        public virtual string Remaining()
        {
            return $": {string.Format("{0:0.00}", this.Fuel)}";
        }
    }
}