using System;

namespace Exercise_03_ShoppingSpree
{
    //Creates a product holding its name and cost.
    public class Product
    {
        private string name;
        private int cost;

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Name cannot be empty");
                }
            }
        }

        public int Cost
        {
            get
            {
                return this.cost;
            }
            private set
            {
                if (value >= 0)
                {
                    this.cost = value;
                }
                else
                {
                    throw new ArgumentException("Money cannot be negative");
                }
            }
        }

        public Product(string name, int cost)
        {
            this.Name = name;
            this.Cost = cost;
        }
    }
}