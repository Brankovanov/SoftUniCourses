using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_03_PeriodicTable
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ReceiveElements();
        }

        private static void ReceiveElements()
        {
            var numberOfElements = int.Parse(Console.ReadLine());
            var hashSetOfElements = new HashSet<string>();

            for (var index = 0; index < numberOfElements; index++)
            {
                var elements = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);

                foreach(var element in elements)
                {
                    if (!hashSetOfElements.Contains(element))
                    {
                        hashSetOfElements.Add(element);
                    }
                }              
            }

            PrintNames(hashSetOfElements);
        }

        private static void PrintNames(HashSet<string> hashSetOfElements)
        {
            foreach (var element in hashSetOfElements.OrderBy(e=>e))
            {
                Console.Write(element + " ");
            }
        }
    }
}
