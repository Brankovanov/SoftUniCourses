using System;
using System.Collections.Generic;

namespace Exercise_04_PizzaCalories
{
    //Creates a pizza object that holds the pizza's name, a list with the pizza toppings and the pizza's dough and calculates the pizza's calories.
    public class Pizza
    {
        private string name;
        private List<Toppings> topping;
        private Dough plate;

        public Dough Plate
        {
            get
            {
                return this.plate;
            }
            internal set
            {
                this.plate = value;
            }
        }

        public List<Toppings> Topping
        {
            get
            {
                if (topping.Count < 10)
                {
                    return this.topping;
                }
                else
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }
            }
            internal set
            {
                this.topping = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            internal set
            {
                if ((!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value)) && value.Length <= 15)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
            }
        }

        public Pizza()
        {
            this.topping = new List<Toppings>();
        }

        public decimal TotalCalories()
        {
            var totalCalories = 0.0M;

            foreach (var t in Topping)
            {
                totalCalories += t.CalculateToppingCalories();
            }

            totalCalories += Plate.CalculateDoughtCalories();
            return totalCalories;
        }
    }
}