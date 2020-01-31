using System;
using System.Collections.Generic;

namespace Ex_01_UniqueNames
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ReceiveName();
        }

        private static void ReceiveName()
        {
            var numberOfNames = int.Parse(Console.ReadLine());
            var hashSetOfNames = new HashSet<string>();

            for (var index = 0; index < numberOfNames; index++)
            {
                var names = Console.ReadLine();

                if (!hashSetOfNames.Contains(names))
                {
                    hashSetOfNames.Add(names);
                }

            }

            PrintNames(hashSetOfNames);
        }

        private static void PrintNames(HashSet<string> hashSetOfNames)
        {
            foreach (var name in hashSetOfNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
