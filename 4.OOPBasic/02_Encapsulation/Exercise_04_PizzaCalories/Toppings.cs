using System;

namespace Exercise_04_PizzaCalories
{
    //Creates a topping object that holds the topping type and quantity and calculates the topping's calories.
    public class Toppings
    {
        private string type;
        private decimal weight;

        public decimal Weight
        {
            get
            {
                return this.weight;
            }
            private set
            {
                if (value > 0 && value <= 50)
                {
                    this.weight = value;
                }
                else
                {
                    throw new ArgumentException($"{Type} weight should be in the range [1..50].");
                }
            }
        }

        public string Type
        {
            get
            {
                return this.type;
            }
            private set
            {
                if (value.ToLower() == "meat" || value.ToLower() == "veggies" || value.ToLower() == "cheese" || value.ToLower() == "sauce")
                {
                    this.type = value;
                }
                else
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
            }
        }

        public Toppings(string type, decimal weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        public decimal CalculateToppingCalories()
        {
            var mod = 0.0M;

            if (type.ToLower() == "meat")
            {
                mod = 1.2M;
            }
            else if (type.ToLower() == "veggies")
            {
                mod = 0.8M;
            }
            else if (type.ToLower() == "cheese")
            {
                mod = 1.1M;
            }
            else if (type.ToLower() == "sauce")
            {
                mod = 0.9M;
            }

            return (weight * 2) * mod;
        }
    }
}