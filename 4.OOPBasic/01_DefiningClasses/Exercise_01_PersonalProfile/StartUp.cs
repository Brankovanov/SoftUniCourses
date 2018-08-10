using System;
using System.Collections.Generic;

namespace Exercise_01_PersonalProfile
{
    public class StartUp
    {
        public static void Main()
        {
            ReceivePeople();
        }

        //Receives information for the people.
        public static void ReceivePeople()
        {
            var familia = new Family();
            familia.FamilyMembers = new List<Person>();
            var numberOfPeople = int.Parse(Console.ReadLine());

            for (var index = 1; index <= numberOfPeople; index++)
            {
                var information = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var name = information[0];
                var age = int.Parse(information[1]);

                CreatePerson(name, age, familia);
            }

            Print(familia);
        }

        //Creates objects newPerson and prints their properties.
        public static void CreatePerson(string name, int age, Family familia)
        {
            var newPerson = new Person(name, age);
            familia.AddMember(newPerson);
        }

        //Prints the persons data.
        public static void Print(Family familia)
        {
            familia.PrintOldest(familia.FamilyMembers);
            familia.PrintPeopleOverThirty(familia.FamilyMembers);
        }
    }
}