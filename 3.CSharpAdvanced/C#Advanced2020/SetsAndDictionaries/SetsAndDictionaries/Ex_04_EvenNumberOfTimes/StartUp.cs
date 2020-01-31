using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_04_EvenNumberOfTimes
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ReceiveNumbers();
        }

        private static void ReceiveNumbers()
        {
            var numberOfNumbers = int.Parse(Console.ReadLine());
            var collectionOfNumbers = new Dictionary<int, int>();
            var number = 0;

            for (var index = 0; index < numberOfNumbers; index++)
            {
                number = int.Parse(Console.ReadLine());

                if (collectionOfNumbers.ContainsKey(number))
                {
                    collectionOfNumbers[number]++;
                }
                else
                {
                    collectionOfNumbers.Add(number, 1);
                }
            }

            Print(collectionOfNumbers);
        }

        private static void Print(Dictionary<int, int> collectionOfNumbers)
        {
            foreach (var n in collectionOfNumbers.Where(n => n.Value % 2 == 0))
            {
                Console.WriteLine(n.Key);
            }
        }
    }
}
