using System;
using System.Collections.Generic;

namespace Exercise_06_EqualityLogic
{
    public class StartUp
    {
        static void Main()
        {
            var sortedSet = new SortedSet<Person>(new Comparer());
            var hashSet = new HashSet<Person>(new EqualityComparer());
            ReceiveInput(sortedSet, hashSet);
            PrintSizes(sortedSet, hashSet);

            foreach (var person in sortedSet)
            {
                Console.WriteLine(person.Name + " -> " + person.Age);
            }
        }

        //Receives input from the console.
        public static void ReceiveInput(SortedSet<Person> sortedSet, HashSet<Person> hashSet)
        {
            var numberOfPeople = int.Parse(Console.ReadLine());

            for (var index = 0; index < numberOfPeople; index++)
            {
                var information = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var name = information[0].Trim();
                var age = int.Parse(information[1]);

                CreatePeople(sortedSet, hashSet, name, age);
            }
        }

        //Creates new person objects and records the m in sets.
        public static void CreatePeople(SortedSet<Person> sortedSet, HashSet<Person> hashSet, string name, int age)
        {
            var newPerson = new Person(name, age);
            sortedSet.Add(newPerson);
            hashSet.Add(newPerson);
        }

        //Prints the sizes of the both sets.
        public static void PrintSizes(SortedSet<Person> sortedSet, HashSet<Person> hashSet)
        {
            Console.WriteLine(sortedSet.Count);
            Console.WriteLine(hashSet.Count);
        }
    }
}