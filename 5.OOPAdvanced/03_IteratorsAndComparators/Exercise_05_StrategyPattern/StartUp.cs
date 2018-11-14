using System;
using System.Collections.Generic;

namespace Exercise_05_StrategyPattern
{
    public class StartUp
    {
        public static void Main()
        {
            ReceiveInput();
        }

        //Receives input from the console.
        public static void ReceiveInput()
        {
            var numberOfPeople = int.Parse(Console.ReadLine());
            var nameSet = new SortedSet<Person>(new CompareNames());
            var ageSet = new SortedSet<Person>(new AgeComparer());

            for (var index = 0; index < numberOfPeople; index++)
            {
                var information = Console.ReadLine();
                var temp = information.Split(' ');
                var name = temp[0];
                var age = int.Parse(temp[1]);
                var newPerson = new Person(name, age);
                nameSet.Add(newPerson);
                ageSet.Add(newPerson);
            }

            PrintSets(nameSet, ageSet);
        }

        //Prints the sorted sets.
        public static void PrintSets(SortedSet<Person> nameSet, SortedSet<Person> ageSet)
        {
            foreach (var p in nameSet)
            {
                Console.WriteLine(p.Name + " " + p.Age);
            }

            foreach (var p in ageSet)
            {
                Console.WriteLine(p.Name + " " + p.Age);
            }
        }
    }
}