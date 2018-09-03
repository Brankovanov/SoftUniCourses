using System;
using System.Collections.Generic;

namespace Exercise_07_Animals
{
    public class StartUp
    {
        static void Main()
        {
            ReceiveAnimals();
        }

        //Receives animals' information from the console.
        public static void ReceiveAnimals()
        {
            var listOfAnimals = new List<Animal>();
            var animal = Console.ReadLine();
            var characteristics = Console.ReadLine();

            while (!animal.Equals("Beast!") && !characteristics.Equals("Beast!"))
            {
                CreateAnimal(animal, characteristics, listOfAnimals);
                animal = Console.ReadLine();
                characteristics = Console.ReadLine();
            }

            Print(listOfAnimals);
        }

        //Creates the new animals.
        public static void CreateAnimal(string animal, string characteristics, List<Animal> listOfAnimals)
        {
            var name = string.Empty;
            var age = 0;
            var sex = string.Empty;

            var temp = characteristics.Split(' ');
            name = temp[0];
            age = int.Parse(temp[1]);
            sex = temp[2];

            switch (animal)
            {
                case "Animal":

                    try
                    {
                        var newAnimal = new Animal(name, age, sex, animal);
                        listOfAnimals.Add(newAnimal);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    break;

                case "Cat":

                    try
                    {
                        var newCat = new Cat(name, age, sex, animal);
                        listOfAnimals.Add(newCat);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    break;

                case "Kitten":

                    try
                    {
                        var newKitten = new Kitten(name, age, sex, animal);
                        listOfAnimals.Add(newKitten);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    break;

                case "Tomcat":

                    try
                    {
                        var newTomcat = new Tomcat(name, age, sex, animal);
                        listOfAnimals.Add(newTomcat);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    break;

                case "Dog":

                    try
                    {
                        var newDog = new Dog(name, age, sex, animal);
                        listOfAnimals.Add(newDog);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    break;

                case "Frog":

                    try
                    {
                        var newFrog = new Frog(name, age, sex, animal);
                        listOfAnimals.Add(newFrog);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    break;

                default:
                    {
                        Console.WriteLine("Invalid input!");
                        break;
                    }
            }
        }

        //Prints all the created animals.
        public static void Print(List<Animal> listOfAnimals)
        {
            foreach (var entity in listOfAnimals)
            {
                Console.WriteLine(entity.Kind);
                Console.WriteLine(entity.Name + " " + entity.Age + " " + entity.Gender);
                Console.WriteLine(entity.ProduceSound());
            }
        }
    }
}