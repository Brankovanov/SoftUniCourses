using System;
using System.Collections.Generic;

namespace Exercise_08_PetClinic
{
    public class StartUpt
    {
        public static void Main()
        {
            var listOfPets = new List<Pet>();
            var listOfClinics = new List<Clinic>();
            ReceiveInput(listOfPets, listOfClinics);
        }

        //Receives input from the console.
        public static void ReceiveInput(List<Pet> listOfPets, List<Clinic> listOfClinics)
        {
            var n = int.Parse(Console.ReadLine());

            for (var index = 0; index < n; index++)
            {
                var command = Console.ReadLine();
                PerformCommand(command, listOfPets, listOfClinics);
            }
        }

        //Performs the command received from the console.
        public static void PerformCommand(string command, List<Pet> listOfPets, List<Clinic> listOfClinics)
        {
            var temp = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var type = temp[0];
            var name = string.Empty;

            switch (type)
            {
                case "Create":
                    var entity = temp[1];

                    switch (entity)
                    {
                        case "Clinic":
                            try
                            {
                                var designation = temp[2];
                                var rooms = int.Parse(temp[3]);
                                var newClinic = new Clinic(rooms, designation);
                                listOfClinics.Add(newClinic);
                            }
                            catch (ArgumentException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;

                        case "Pet":
                            name = temp[2];
                            var age = int.Parse(temp[3]);
                            var kind = temp[4];
                            var newPet = new Pet(name, age, kind);
                            listOfPets.Add(newPet);
                            break;
                    }
                    break;

                case "Add":
                    var petName = temp[1];
                    var clinicName = temp[2];
                    Console.WriteLine(listOfClinics.Find(c => c.Name == clinicName).Admiting(listOfPets.Find(p => p.Name == petName)));
                    break;

                case "Release":
                    clinicName = temp[1];
                    Console.WriteLine(listOfClinics.Find(c => c.Name == clinicName).Releasing());
                    break;

                case "HasEmptyRooms":
                    clinicName = temp[1];
                    Console.WriteLine(listOfClinics.Find(c => c.Name == clinicName).HasEmpty());
                    break;

                case "Print":
                    if (temp.Length == 2)
                    {
                        clinicName = temp[1];
                        Console.WriteLine(listOfClinics.Find(c => c.Name == clinicName).Print());
                    }
                    else
                    {
                        clinicName = temp[1];
                        var room = int.Parse(temp[2]);
                        Console.WriteLine(listOfClinics.Find(c => c.Name == clinicName).PrintRoom(room));
                    }
                    break;
            }
        }
    }
}