using System;
using System.Collections.Generic;

namespace _04_PizzaCalories
{
    public class Pizza
    {
        private Dough dough;
        private List<Topping> topping = new List<Topping>();
        private string name;

        public Dough Dough
        {
            get
            {
                return this.dough;
            }
            private set
            {
                this.dough = value;
            }
        }

        public List<Topping> Topping
        {
            get
            {
                return this.topping;
            }
            private set
            {
                if(value.Count>10)
                {
                    throw new ArgumentException("Number of toppings should be in range[0..10].");
                }
                else
                {
                    this.topping = value;
                }
                
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if(value==string.Empty || value.Length>15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                else
                {
                    this.name = value;
                }
             
            }
        }

        public Pizza(Dough dough, List<Topping> topping, string name)
        {
            this.Dough = dough;
            this.Topping=topping;
            this.Name = name;
        }

        public double CalculateTotalCalories()
        {
            var totalCalories = 0.0;
            
            foreach(var top in this.Topping)
            {
                totalCalories += top.CalculateCalories();
            }

            totalCalories += this.Dough.CalculateCalories();

            return totalCalories;
        }
    }
}