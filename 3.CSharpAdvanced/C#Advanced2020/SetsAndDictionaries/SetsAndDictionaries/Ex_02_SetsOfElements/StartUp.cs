using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_02_SetsOfElements
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ReceiveSets();
        }

        private static void ReceiveSets()
        {
            var setParameters = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();
            var setOne = new HashSet<int>();
            var setTwo = new HashSet<int>();
            var numbers = 0;

            for (var index = 0; index < setParameters[0]; index++)
            {
                numbers = int.Parse(Console.ReadLine());

                if (!setOne.Contains(numbers))
                {
                    setOne.Add(numbers);
                }

            }

            for (var index = 0; index < setParameters[1]; index++)
            {
                numbers = int.Parse(Console.ReadLine());

                if (!setTwo.Contains(numbers))
                {
                    setTwo.Add(numbers);
                }
            }

            PrintSets(setOne, setTwo);
        }

        private static void PrintSets(HashSet<int> setOne, HashSet<int> setTwo)
        {
            foreach (var number in setOne)
            {
                foreach (var n in setTwo)
                {
                    if (number == n)
                    {
                        Console.Write(number + " ");
                    }
                }
            }
        }
    }
}