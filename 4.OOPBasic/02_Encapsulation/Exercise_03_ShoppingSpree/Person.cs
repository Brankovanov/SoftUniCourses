using System;
using System.Collections.Generic;

namespace Exercise_03_ShoppingSpree
{
    //Creates a person object that holds the persons' name, money and list of products bought.
    public class Person
    {
        private string name;
        private int money;
        private List<Product> bagOfProducts;

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

        public int Money
        {
            get
            {
                return this.money;
            }
            set
            {
                if (value >= 0)
                {
                    this.money = value;
                }
                else
                {
                    throw new ArgumentException("Money cannot be negative");
                }
            }
        }

        public List<Product> BagOfProducts
        {
            get
            {
                return this.bagOfProducts;
            }
        }

        public Person(string name, int money)
        {
            this.Name = name;
            this.Money = money;
            this.bagOfProducts = new List<Product>();
        }
    }
}