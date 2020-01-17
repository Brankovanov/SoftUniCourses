
using System;
using System.Collections.Generic;

namespace _03_ShoppingSpree
{
    public class Person
    {
        private string name;
        private double money;
        private List<Product> bagOfProducts;

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = value;
            }
        }

        public double Money
        {
            get
            {
                return this.money;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                else
                {
                    this.money = value;
                }
            }
        }

        public List<Product> BagOfProducts
        {
            get
            {
                return this.bagOfProducts;
            }
            private set
            {
                this.bagOfProducts = value;
            }
        }

        public void GoShopping(Product product)
        {
            if (product.Cost <= this.Money)
            {
                this.BagOfProducts.Add(product);
                this.Money = this.Money - product.Cost;

                Console.WriteLine($"{this.Name} bought {product.Name}");
            }
            else
            {
                throw new ArgumentException($"{this.Name} can't afford {product.Name}");
            }
        }

        public override string ToString()
        {
            var output = string.Empty;

            if (this.BagOfProducts.Count > 0)
            {
                output += this.Name + " - ";

                foreach (var item in this.BagOfProducts)
                {
                    output += $"{item.Name}, ";
                }
            }
            else
            {
                output = "Nothing bought";
            }

            return output.TrimEnd(',', ' ');
        }

        public Person(string name, double money)
        {
            this.Name = name;
            this.Money = money;
            this.BagOfProducts = new List<Product>();
        }
    }
}