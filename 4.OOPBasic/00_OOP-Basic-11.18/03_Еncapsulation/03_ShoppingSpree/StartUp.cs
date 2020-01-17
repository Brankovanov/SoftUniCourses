using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_ShoppingSpree
{
    public class StartUp
    {
        static void Main()
        {
            ReceiveInput();
        }

        public static void ReceiveInput()
        {
            var people = Console.ReadLine()
                .Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var products = Console.ReadLine()
                .Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var listOfPeople = new List<Person>();
            var listOfProducts = new List<Product>();
            var shoppingList = new List<string>();

            var purchase = Console.ReadLine();

            while (purchase != "END")
            {
                shoppingList.Add(purchase);
                purchase = Console.ReadLine();
            }

            CreatePeople(listOfPeople, people);
            CreateProducts(listOfProducts, products);

            GoShopping(listOfPeople, listOfProducts, shoppingList);
            PrintResults(listOfPeople);
        }

        public static void CreatePeople(List<Person> listOfPeople, List<string> people)
        {
            foreach (var person in people)
            {
                var temp = person.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                var name = temp[0];
                var money = double.Parse(temp[1]);

                try
                {
                    var newPerson = new Person(name, money);
                    listOfPeople.Add(newPerson);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static void CreateProducts(List<Product> listOfProducts, List<string> products)
        {
            foreach (var product in products)
            {
                var temp = product.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                var name = temp[0];
                var cost = double.Parse(temp[1]);

                try
                {
                    var newProduct = new Product(name, cost);
                    listOfProducts.Add(newProduct);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static void GoShopping(List<Person> listOfPeople, List<Product> listOfProducts, List<string> shoppingList)
        {
            foreach (var poin in shoppingList)
            {
                var temp = poin.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var shopper = temp[0];
                var product = temp[1];

                try
                {
                    listOfPeople.FindAll(p => p.Name == shopper).ForEach(p => p.GoShopping(listOfProducts.Find(t => t.Name == product)));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static void PrintResults(List<Person> listOfPeople)
        {
            foreach (var person in listOfPeople)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}