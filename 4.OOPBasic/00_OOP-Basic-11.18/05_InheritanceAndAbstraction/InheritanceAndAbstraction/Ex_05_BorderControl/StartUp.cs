using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_05_BorderControl
{
    public class StartUp
    {
        static void Main()
        {
            ReceiveInput();
        }

        public static void ReceiveInput()
        {
            var newBorder = new Border();
            var listOfEntities = new List<Entity>();
            var count = int.Parse(Console.ReadLine());

            var incoming = Console.ReadLine();

            for (var counter = 0; counter < count; counter++)
            {
                var temp = incoming.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                CreateEntity(temp, listOfEntities);

                incoming = Console.ReadLine();
            }

            var name = Console.ReadLine();

            while (name != "End")
            {
                BuyFood(listOfEntities, name);
                name = Console.ReadLine();
            }

            CalculateFood(listOfEntities);
            // while (incoming != "End")
            // {
            //     var temp = incoming.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //
            //     CreateEntity(temp, listOfEntities);
            //
            //     incoming = Console.ReadLine();
            // }
            //
            // var birthYear = Console.ReadLine();
            // CheckBirthDate(birthYear, listOfEntities);
            //
            // var filter = Console.ReadLine();
            // CheckTraffic(filter, listOfEntities, newBorder);
        }

        public static void CalculateFood(List<Entity> listOfEntities)
        {
            var totalFood = 0;

            foreach (var person in listOfEntities)
            {
             
                    totalFood += person.Food;
               
            }

            Console.WriteLine(totalFood);
        }
        public static void BuyFood(List<Entity> listOfEntities, string name)
        {
            try
            {
                listOfEntities.Find(n => n.Name == name).BuyFood();
            }
            catch
            {
                Console.WriteLine($"{name} is not in the list.");
            }
         

        }

        public static void CheckBirthDate(string birthYear, List<Entity> listOfEntities)
        {
            foreach (var thing in listOfEntities)
            {
                try
                {
                    if (thing.BirthDate.EndsWith(birthYear))
                    {

                        Console.WriteLine(thing.BirthDate);
                    }
                }
                catch
                {
                    Console.WriteLine("Robots do not have birthdates!");
                }
            }
        }

        public static void CreateEntity(string[] temp, List<Entity> listOfEnties)
        {
            if (temp.Length == 4)
            {
                var name = temp[0];
                var age = int.Parse(temp[1]);
                var id = temp[2];
                var birthDate = temp[3];

                var newCitizen = new Citizen(id, name, age, birthDate);
                listOfEnties.Add(newCitizen);
            }
            else if (temp.Length == 3)
            {
                var name = temp[0];
                var age = int.Parse(temp[1]);
                var group = temp[2];


                var newRebel = new Rebel(name, group, age);
                listOfEnties.Add(newRebel);
            }

            //  var type = temp[0];

            // switch (type)
            // {
            //     case "Pet":
            //
            //         var name = temp[1];
            //         var birthDate = temp[2];
            //         var newPet = new Pet(name, birthDate);
            //         listOfEnties.Add(newPet);
            //         break;
            //
            //     case "Citizen":
            //
            //         name = temp[1];
            //         var age = int.Parse(temp[2]);
            //         var id = temp[3];
            //         birthDate = temp[4];
            //         var newCitizen = new Citizen(id, name, age, birthDate);
            //         listOfEnties.Add(newCitizen);
            //         break;
            //
            //     case "Robot":
            //
            //         var model = temp[1];
            //         id = temp[2];
            //         var newRobot = new Robot(id, model);
            //         listOfEnties.Add(newRobot);
            //         break;
            //
            //     case "Rebel":
            //
            //         name = temp[1];
            //         age = int.Parse(temp[2]);
            //         var group = temp[3];
            //         var newRebel = new Rebel(name, group, age);
            //         listOfEnties.Add(newRebel);
            //         break;
            //
            // }
        }


        public static void CheckTraffic(string filter, List<Entity> listOfEntities, Border newBorder)
        {
            foreach (var entity in listOfEntities)
            {
                try
                {
                    newBorder.Detain(filter, entity);
                }
                catch
                {
                    Console.WriteLine("Pets do not have ids!");
                }
            }

            foreach (var detained in newBorder.Rebels)
            {
                Console.WriteLine(detained.Id);
            }
        }


    }
}
