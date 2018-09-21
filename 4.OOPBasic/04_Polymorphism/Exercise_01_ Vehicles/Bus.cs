using System;

namespace Exercise_01__Vehicles
{
    //A child class of vechicles class.
    public class Bus : Vehicles
    {
        public Bus(double fuel, double consumption, double tankCapacity, bool passenger)
            : base(fuel, consumption, tankCapacity, passenger)
        {
        }

        public override string Drive(double distance)
        {
            var consumedFuel = 0.0;

            if (this.Passanger == true)
            {
                consumedFuel = (this.Consumption + 1.4) * distance;
            }
            else
            {
                consumedFuel = (this.Consumption) * distance;
                this.Passanger = true;
            }

            if (this.Fuel >= consumedFuel)
            {
                this.Fuel = this.Fuel - consumedFuel;
                return this.GetType().Name + base.Drive(distance);
            }
            else
            {
                throw new ArgumentException("Bus needs refueling");
            }
        }

        public override void Refuel(double quantityRefueld)
        {
            if (this.Fuel + quantityRefueld > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {quantityRefueld} fuel in the tank");
            }
            else if (quantityRefueld <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            else
            {
                this.Fuel += quantityRefueld;
            }
        }

        public override string Remaining()
        {
            return this.GetType().Name + base.Remaining();
        }
    }
}