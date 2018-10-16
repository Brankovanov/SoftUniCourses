using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_07_FoodShortage
{
    public class StartUp
    {
        static void Main()
        {
            ReceiveInfo();
        }

        //Receives information from the console.
        public static void ReceiveInfo()
        {
            var entities = new List<IBuyer>();
            var numberOfPeople = int.Parse(Console.ReadLine());

            for (var index = 0; index < numberOfPeople; index++)
            {
                var person = Console.ReadLine().Split(' ');

                CreatePeople(person, entities);
            }

            var buyers = Console.ReadLine();

            while (buyers != "End")
            {
                BuyFood(buyers, entities);
                buyers = Console.ReadLine();
            }

            CalculateFood(entities);

        }

        //Creates new citizens and rebels.
        public static void CreatePeople(string[] person, List<IBuyer> entities)
        {
            var name = string.Empty;
            var age = 0;
            var id = string.Empty;
            var birthdate = string.Empty;
            var group = string.Empty;

            name = person[0];
            age = int.Parse(person[1]);

            if (person.Length == 4)
            {
                id = person[2];
                birthdate = person[3];
                IBuyer newCitizen = new Citizen(birthdate, name, age, id);
                entities.Add(newCitizen);
            }
            else
            {
                group = person[2];
                IBuyer newRebel = new Rebel(group, name, age);
                entities.Add(newRebel);
            }
        }

        //Buy food.
        public static void BuyFood(string buyers, List<IBuyer> entities)
        {
            if (entities.Any(e => e.Name == buyers))
            {
                entities.Find(e => e.Name == buyers).BuyFood();
            }
        }

        //Calculates the total ood bought.
        public static void CalculateFood(List<IBuyer> entities)
        {
            var totalFood = 0;

            foreach (var entity in entities)
            {
                totalFood += entity.Food;
            }

            PrintTotalFood(totalFood);
        }

        //Prints the total amount of food bouth on the console.
        public static void PrintTotalFood(int totalFood)
        {
            Console.WriteLine(totalFood);
        }
    }
}