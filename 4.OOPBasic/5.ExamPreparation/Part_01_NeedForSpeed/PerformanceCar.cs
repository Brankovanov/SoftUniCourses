using System.Collections.Generic;

namespace Part_01_NeedForSpeed
{
    //Child class to the parent class car.
    public class PerformanceCar : Car
    {
        private List<string> addOns;

        public List<string> AddOns
        {
            get
            {
                return this.addOns;
            }
            set
            {
                this.addOns = value;
            }
        }

        public PerformanceCar(string brand, string model, int yearOfProduction, int horsePower, int acceleration, int suspension, int durability, int id, string type)
        : base(brand, model, yearOfProduction, horsePower, acceleration, suspension, durability, id, type)
        {
            base.HorsePower = horsePower + (horsePower / 2);
            base.Suspension = suspension - (suspension / 4);
            this.AddOns = new List<string>();
        }

        public override string ToString()
        {
            if (AddOns.Count > 0)
            {
                return "Add-Ons: " + string.Join(", ", this.AddOns);
            }
            else
            {
                return "Add-Ons: None";
            }
        }

        public override void Tune(int index, string addons)
        {
            this.HorsePower = this.HorsePower + index;
            this.Suspension = this.Suspension + (index / 2);
            this.AddOns.Add(addons);
        }
    }
}