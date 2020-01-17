using System;

namespace Lab_05_AnimalFarm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            ReceiveInput();

        }

        public static void ReceiveInput()
        {
            var animal = Console.ReadLine();
            var animalFarm = new Farm();

            while (animal != "Beast!")
            {
                var animalInformation = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None);
                var name = animalInformation[0];
                var age = int.Parse(animalInformation[1]);
                var gender = animalInformation[2];


                CreateAnimal(animal, name, age, gender, animalFarm);
                animal = Console.ReadLine();
            }

            PrintInformation(animalFarm);
        }

        public static void CreateAnimal(string animal, string name, int age, string gender, Farm animalFarm)
        {
            try
            {
                switch (animal)
                {
                    case "Dog":
                        var newDog = new Dog(name, age, gender);
                        animalFarm.Animals.Add(newDog);
                        break;
                    case "Cat":
                        var newCat = new Cat(name, age, gender);
                        animalFarm.Animals.Add(newCat);
                        break;
                    case "Frog":
                        var newFrog = new Frog(name, age, gender);
                        animalFarm.Animals.Add(newFrog);
                        break;
                    case "Kittens":
                        var newKittens = new Kitten(name, age, gender);
                        animalFarm.Animals.Add(newKittens);
                        break;
                    case "Tomcat":
                        var newTomcat = new TomCat(name, age, gender);
                        animalFarm.Animals.Add(newTomcat);
                        break;
                }
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void PrintInformation(Farm animalFarm)
        {
            foreach(var beast in animalFarm.Animals)
            {
                Console.WriteLine(beast.GetType().ToString().Replace("Lab_05_AnimalFarm.",""));
                Console.WriteLine($"{beast.Name} {beast.Age} {beast.Gender}");
                Console.WriteLine(beast.ProduceSound());
            }
        }
    }
}
