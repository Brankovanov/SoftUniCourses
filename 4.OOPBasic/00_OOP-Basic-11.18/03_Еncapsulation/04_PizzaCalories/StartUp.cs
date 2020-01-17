using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_PizzaCalories
{
    public class StartUp
    {
        public static void Main()
        {
            ReceiveInput();
        }

        public static void ReceiveInput()
        {
            var temporary = new List<List<string>>();
            var receiveName = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var name = receiveName[1];
            var receiveDough = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var type = receiveDough[1];
            var technique = receiveDough[2];
            var weight = double.Parse(receiveDough[3]);

            var topping = Console.ReadLine();

            while (topping != "END")
            {
                var temp = topping.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                temporary.Add(temp);
                topping = Console.ReadLine();
            }

           CalculateTotalCalories( CreatePizza(name,type,technique,weight, temporary));

        }

        public static Pizza CreatePizza(string name, string type, string technique, double weight, List<List<string>>temporaty)
        {
            var newDough = new Dough(type, technique, weight);
            var listOfTopping = new List<Topping>();

            foreach(var item in temporaty)
            {
                var toppingType = item[1];
                var toppingWeight = double.Parse(item[2]);

                var newTopping = new Topping(toppingType, toppingWeight);
                listOfTopping.Add(newTopping);

            }

            var newPizza = new Pizza(newDough, listOfTopping, name);

            return newPizza;

        }

        public static void CalculateTotalCalories(Pizza pizza)
        {
            var totalCalories = pizza.CalculateTotalCalories();

            Console.WriteLine(pizza.Name + " - " + string.Format("{0:0.00}", totalCalories));
        }
    }
}