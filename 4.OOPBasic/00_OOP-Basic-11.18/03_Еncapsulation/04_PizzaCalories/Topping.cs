using System;

namespace _04_PizzaCalories
{
    public class Topping
    {
        private string type;
        private double weight;
        
        public string Type
        {
            get
            {
                return this.type;
            }
            private set
            {
                if(value!= "Meat" && value!="Veggies" && value!="Cheese" && value!="Sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                else
                {
                    this.type = value;
                }
            }
        }

        public double Weight
        {
            get
            {
                return this.weight;
            }
            private set
            {
                if(value<1 || value>50)
                {
                    throw new ArgumentException($"{this.Type} weight should be in the range [1..50].");
                }

                this.weight = value;
            }
        }

        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        public double CalculateCalories()
        {
            switch (this.Type)
            {
                case "Meat":
                    return (this.Weight * 2) * 1.2;

                case "Veggies":
                    return (this.Weight * 2) * 0.8;

                case "Cheese":
                    return (this.Weight * 2) * 1.1;

                case "Sauce":
                    return (this.Weight * 2) * 0.9;

                default:
                    return 0;
            }
        }
    }
}
