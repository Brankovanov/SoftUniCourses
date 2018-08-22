using System;
using System.Collections.Generic;

namespace Exercise_03_ShoppingSpree
{
    public class StartUp
    {
        private static object exit;

        public static void Main()
        {
            ReceiveInput();
        }

        //Receives commands from the console.
        public static void ReceiveInput()
        {
            var listOfBuyers = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            var listOfProducts = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            var buyers = new List<Person>();
            var products = new List<Product>();

            CreateBuyers(listOfBuyers, buyers);
            CreateProduct(listOfProducts, products);

            var command = Console.ReadLine();

            while (command != "END")
            {
                var temp = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var buyer = temp[0];
                var product = temp[1];

                BuyProduct(buyer, product, buyers, products);

                command = Console.ReadLine();
            }

            Print(buyers);
        }

        //Creates new buyers and records them in a list.
        public static void CreateBuyers(string[] listOfBuyers, List<Person> buyers)
        {
            foreach (var buyer in listOfBuyers)
            {
                var temp = buyer.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                var name = temp[0];
                var purce = int.Parse(temp[1]);

                try
                {
                    var newPerson = new Person(name, purce);
                    buyers.Add(newPerson);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(1);
                }
            }
        }

        //Creates products and records them in a list.
        public static void CreateProduct(string[] listOfProducts, List<Product> products)
        {
            foreach (var prod in listOfProducts)
            {
                var temp = prod.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                var name = temp[0];
                var price = int.Parse(temp[1]);

                try
                {
                    var newProduct = new Product(name, price);
                    products.Add(newProduct);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(1);
                }
            }
        }

        //Checks if a person can buy a product.
        public static void BuyProduct(string buyer, string product, List<Person> buyers, List<Product> products)
        {
            if (buyers.Find(b => b.Name == buyer).Money >= products.Find(p => p.Name == product).Cost)
            {
                buyers.Find(b => b.Name == buyer).BagOfProducts.Add(products.Find(p => p.Name == product));
                buyers.Find(b => b.Name == buyer).Money = buyers.Find(b => b.Name == buyer).Money - products.Find(p => p.Name == product).Cost;
            }
            else
            {
                Console.WriteLine($"{buyer} can't afford {product}");
            }
        }

        //Prints the buyed products.
        public static void Print(List<Person> buyers)
        {
            foreach (var b in buyers)
            {
                if (b.BagOfProducts.Count > 0)
                {

                    foreach (var p in b.BagOfProducts)
                    {
                        Console.WriteLine(b.Name + " bought " + p.Name);
                    }
                }
                else
                {
                    Console.WriteLine(b.Name + " - Nothing bought");
                }
            }
        }
    }
}