using System;
using System.Collections.Generic;

namespace Lab_05_UniqueNames
{
    class StartUp
    {
        static void Main(string[] args)
        {
            CreateListOfNames();
        }

        private static void CreateListOfNames()
        {
            var numberOfNames = int.Parse(Console.ReadLine());
            var listOfNames = new List<string>(); var uniqueNames = new HashSet<string>();

            for (var index = 1; index <= numberOfNames; index++)
            {
                var name = Console.ReadLine();

                if (!uniqueNames.Contains(name))
                {
                    uniqueNames.Add(name);
                }
            }

            PrintUnique(uniqueNames);
        }

        private static void PrintUnique(HashSet<string> uniqueNames)
        {
            foreach(var name in uniqueNames)
            {
                Console.WriteLine(name);
            }
 
        }
    }
}
