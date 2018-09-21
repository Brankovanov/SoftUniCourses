using System;

namespace Exercise_01__Vehicles
{
    //A truck class child of vechicle class.
    public class Truck : Vehicles
    {
        public Truck(double fuel, double consumption, double tankCapacity, bool passenger)
           : base(fuel, consumption, tankCapacity, passenger)
        {
        }

        public override string Drive(double distance)
        {
            var consumedFuel = (this.Consumption + 1.6) * distance;

            if (this.Fuel >= consumedFuel)
            {
                this.Fuel = this.Fuel - consumedFuel;
                return this.GetType().Name + base.Drive(distance);
            }
            else
            {
                return "Truck needs refueling";
            }
        }

        public override void Refuel(double quantityRefueld)
        {
            if (quantityRefueld <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            else if (quantityRefueld + this.Fuel > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {quantityRefueld} fuel in the tank");
            }
            else
            {
                this.Fuel += (quantityRefueld - (quantityRefueld * 0.05));
            }
        }

        public override string Remaining()
        {
            return this.GetType().Name + base.Remaining();
        }
    }
}