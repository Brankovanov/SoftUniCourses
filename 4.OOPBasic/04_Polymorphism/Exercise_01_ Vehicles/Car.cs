using System;

namespace Exercise_01__Vehicles
{
    //A child class of vehicles class.
    public class Car : Vehicles
    {
        public Car(double fuel, double consumption, double tankCapacity, bool passenger)
            : base(fuel, consumption, tankCapacity, passenger)
        {
        }

        public override string Drive(double distance)
        {
            var consumedFuel = (this.Consumption + 0.9) * distance;

            if (this.Fuel >= consumedFuel)
            {
                this.Fuel = this.Fuel - consumedFuel;
                return this.GetType().Name + base.Drive(distance);
            }
            else
            {
                return "Car needs refueling";
            }
        }

        public override string Remaining()
        {
            return this.GetType().Name + base.Remaining();
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
    }
}