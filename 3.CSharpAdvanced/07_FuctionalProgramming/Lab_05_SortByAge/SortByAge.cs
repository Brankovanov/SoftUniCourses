using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_05_SortByAge
{
    public class SortByAge
    {
        public static void Main(string[] args)
        {
            Input();
        }

        //Receive the input from the console.
        public static void Input()
        {
            var numberOfPeople = int.Parse(Console.ReadLine());
            var people = new Dictionary<string, int>();

            for (var n = 1; n <= numberOfPeople; n++)
            {
                var person = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                people.Add(person[0], int.Parse(person[1]));

            }

            var condition = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var format = Console.ReadLine();

            SortThePeople(people, condition, age, format);
        }

        //Sorts the people according to the given condition.
        public static void SortThePeople(Dictionary<string, int> people, string condition, int age, string format)
        {
            if (condition.Equals("younger"))
            {
                foreach (var person in people.Where(p => p.Value < age))
                {
                    Print(person, format);
                }
            }
            else if (condition.Equals("older"))
            {
                foreach (var person in people.Where(p => p.Value > age))
                {
                    Print(person, format);
                }
            }
        }

        //Prints the people that coresponds to the condition.
        public static void Print(KeyValuePair<string, int> person, string format)
        {
            switch (format)
            {
                case "name":
                    Console.WriteLine(person.Key);
                    break;
                case "age":
                    Console.WriteLine(person.Value);
                    break;
                case "name age":
                    Console.WriteLine(person.Key + " - " + person.Value);
                    break;
            }
        }
    }
}