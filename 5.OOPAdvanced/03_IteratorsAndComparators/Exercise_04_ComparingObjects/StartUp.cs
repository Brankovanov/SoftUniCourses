using System;
using System.Collections.Generic;

namespace Exercise_04_ComparingObjects
{
    public class StartUp
    {
        public static void Main()
        {
            CreatePeople();
        }

        //Receives people's inpformation and creates person objects.
        public static void CreatePeople()
        {
            var person = Console.ReadLine();
            var listOfPeople = new List<Person>();

            while (person != "END")
            {
                var characteristics = person.Split(' ');
                var name = characteristics[0];
                var age = int.Parse(characteristics[1]);
                var town = characteristics[2];
                var newPerson = new Person(name, age, town);
                listOfPeople.Add(newPerson);
                person = Console.ReadLine();
            }

            var index = int.Parse(Console.ReadLine());
            Compare(index, listOfPeople);
        }

        //Compare person's objects
        public static void Compare(int index, List<Person> listOfPeople)
        {
            var equal = 0;

            for (var ind = 0; ind < listOfPeople.Count; ind++)
            {
                if (ind != index - 1)
                {
                    equal += listOfPeople[index - 1].CompareTo(listOfPeople[ind]);
                }
            }

            PrintAnswer(equal, listOfPeople);
        }

        //Prints the answer.
        public static void PrintAnswer(int equal, List<Person> listOfPeole)
        {
            if (equal == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                var unequal = listOfPeole.Count - equal - 1;
                Console.WriteLine(equal + 1 + " " + unequal + " " + listOfPeole.Count);
            }
        }
    }
}