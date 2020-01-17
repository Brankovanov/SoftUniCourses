using System;

namespace _03_ShoppingSpree
{
    public class Product
    {
        private string name;
        private double cost;

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (value.Length < 1)
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public double Cost
        {
            get
            {
                return this.cost;
            }
            private set
            {
                this.cost = value;
            }
        }

        public Product(string name, double cost)
        {
            this.Name = name;
            this.Cost = cost;
        }
    }
}