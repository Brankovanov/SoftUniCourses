using System;
using System.Collections.Generic;

namespace Exercise_02_WildFarm
{
    public class StartUp
    {
        public static void Main()
        {
            ReceiveInformation();
        }

        //Receive information from the console.
        public static void ReceiveInformation()
        {
            var listOfAnimals = new List<Animal>();
            var counter = 0;
            var input = Console.ReadLine();
            var type = string.Empty;
            var name = string.Empty;
            var weight = 0.0;
            var region = string.Empty;
            var breed = string.Empty;

            while (input != "End")
            {
                if (counter % 2 == 0)
                {
                    var temp = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    type = temp[0];
                    name = temp[1];
                    weight = double.Parse(temp[2]);
                    region = temp[3];
                    breed = string.Empty;

                    if (type == "Cat")
                    {
                        breed = temp[4];
                    }
                }
                else
                {
                    var temp = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    var typeFood = temp[0];
                    var quantity = int.Parse(temp[1]);

                    switch (typeFood)
                    {
                        case "Meat":
                            var meat = new Meat(quantity, typeFood);
                            CreateAnimals(name, type, weight, region, breed, meat, listOfAnimals);
                            break;

                        case "Vegetable":
                            var vegetable = new Vegetables(quantity, typeFood);
                            CreateAnimals(name, type, weight, region, breed, vegetable, listOfAnimals);
                            break;
                    }
                }

                counter++;
                input = Console.ReadLine();
            }

            PrintResult(listOfAnimals);
        }

        //Creates and records new animals.
        public static void CreateAnimals(string name, string type, double weight, string region, string breed, Food food, List<Animal> listOfAnimals)
        {
            switch (type)
            {
                case "Cat":
                    var newCat = new Cat(name, type, weight, 0, region, breed);
                    FeedAnimal(food, newCat);
                    listOfAnimals.Add(newCat);
                    break;

                case "Mouse":
                    var newMouse = new Mouse(name, type, weight, 0, region);
                    FeedAnimal(food, newMouse);
                    listOfAnimals.Add(newMouse);
                    break;

                case "Tiger":
                    var newTiger = new Tiger(name, type, weight, 0, region);
                    FeedAnimal(food, newTiger);
                    listOfAnimals.Add(newTiger);
                    break;

                case "Zebra":
                    var newZebra = new Zebra(name, type, weight, 0, region);
                    FeedAnimal(food, newZebra);
                    listOfAnimals.Add(newZebra);
                    break;
            }
        }

        //Feeds the animal.
        public static void FeedAnimal(Food food, Animal newAnimal)
        {
            try
            {
                newAnimal.Eat(food);
            }
            catch (ArgumentException x)
            {
                Console.WriteLine(x.Message);
            }
        }

        //Prints the animals after the end of the feeding.
        public static void PrintResult(List<Animal> listOfAnimals)
        {
            foreach (var animal in listOfAnimals)
            {
                Console.WriteLine(animal.MakeSound());
                Console.WriteLine(animal.ToString());
            }
        }
    }
}