﻿using System;

namespace Ex_01_Vehicles
{
    public class Bus : IVehicle
    {
        private double fuel;
        private double fuelConsumption;
        private double tankCapacity;

        public double Fuel
        {
            get
            {
                return this.fuel;
            }
            private set
            {              
                    this.fuel = value;             
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
        public double TankCapacity
        {
            get
            {
                return this.tankCapacity;
            }
            private set
            {
                this.tankCapacity = value;
            }
        }

        public string Drive(double distance)
        {
            if (this.Fuel - ((this.FuelConsumption + 1.4) * distance) >= 0)
            {
                this.Fuel -= (this.FuelConsumption + 1.4) * distance;

                return $"Bus travelled {distance} km";
            }
            else
            {
                return "Bus needs refueling";
            }
        }

        public string DriveEmpty(double distance)
        {
            if (this.Fuel - (this.FuelConsumption * distance) >= 0)
            {
                this.Fuel -= (this.FuelConsumption ) * distance;

                return $"Bus travelled {distance} km";
            }
            else
            {
                return "Bus needs refueling";
            }
        }

        public void Refuel(double quantity)
        {
            if (quantity > 0)
            {
                if (quantity <= this.TankCapacity)
                {
                    this.Fuel += quantity;
                }
                else
                {
                    throw new ArgumentException($"Cannot fit {quantity} fuel in the tank");
                }
            }
            else
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
        }

        public Bus(double fuel, double fuelConsumption, double capacity)
        {
            this.TankCapacity = capacity;

            if (fuel <= capacity)
            {
                this.Fuel = fuel;
            }
            else
            {
                this.Fuel = 0;
            }

            this.FuelConsumption = fuelConsumption;
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} : {string.Format("{0:0.00}", this.Fuel)}";
        }
    }
}
