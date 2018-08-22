using System;

namespace Exercise_04_PizzaCalories
{
    public class PublicCalories
    {
        public static void Main()
        {
            ReceiveInput();
        }

        //Receives input from the console.
        public static void ReceiveInput()
        {
            var newPizza = new Pizza();
            var input = Console.ReadLine();

            while (input != "END")
            {  
                var temp = input.Split(new char[] { ' ' });
                var ingredient = temp[0];

                switch (ingredient)
                {
                    case "Pizza":

                        var name = temp[1];
                        CreatePizza(newPizza,name);                  
                        break;

                    case "Dough":

                        var flourType = temp[1];
                        var bakingTech = temp[2];
                        var quantity = decimal.Parse(temp[3]);
                        AddDough(newPizza, flourType, bakingTech, quantity);      
                        break;

                    case "Topping":
                 
                        var topType = temp[1];
                        var topWeight = decimal.Parse(temp[2]);
                        AddToppings(newPizza, topType, topWeight);
                        break;
                }

                input = Console.ReadLine();
            }

            PrintTotalCalories(newPizza);    
        }

        //Creates new pizza.
       public static void CreatePizza(Pizza newPizza, string name)
        {
            try
            {
                newPizza.Name = name;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
               Environment.Exit(1);
            }
        }

        //Adds dough.
        public static  void AddDough(Pizza newPizza, string flourType, string bakingTech, decimal quantity)
        {
            try
            {
                var pizzaDough = new Dough(flourType, bakingTech, quantity);
                newPizza.Plate = pizzaDough;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(1);
            }
        }

        //Adds toppinngs.
        public static void AddToppings(Pizza newPizza, string topType, decimal topWeight )
        { 
            try
            {
                var top = new Toppings(topType, topWeight);
                newPizza.Topping.Add(top);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(1);
            }
        }

        //Prints the total calories of the pizza.
        public static void PrintTotalCalories(Pizza newPizza)
        {
            Console.WriteLine(newPizza.Name + " - " + string.Format("{0:0.00}", newPizza.TotalCalories()) + " Calories.");
        }
    }
}