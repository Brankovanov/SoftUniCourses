using System;
using System.Collections.Generic;

namespace Exercise_09_ExplicitInterface
{
    public class StartUp
    {
        static void Main()
        {
            ReceivePersonalInformation();
        }

        //Receives persons information from the console.
        public static void ReceivePersonalInformation()
        {
            var person = Console.ReadLine();
            var listOfPeople = new List<Citizen>();

            while (person != "End")
            {
                var temp = person.Split(' ');
                var name = temp[0];
                var country = temp[1];
                var age = int.Parse(temp[2]);

                listOfPeople.Add(CreatePerson(name, country, age));
                person = Console.ReadLine();
            }

            GetName(listOfPeople);
        }

        //Creates a new person object
        public static Citizen CreatePerson(string name, string country, int age)
        {
            var newCitizen = new Citizen(name, country, age);
            return newCitizen;
        }

        //Prints the name of the people on the list.
        public static void GetName(List<Citizen> listOfPeople)
        {
            foreach (var entity in listOfPeople)
            {
                IPerson person = entity;
                Console.WriteLine(person.GetName());
                IResident resident = entity;
                Console.WriteLine(resident.GetName());
            }
        }
    }
}