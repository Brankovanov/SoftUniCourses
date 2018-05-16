using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_01_CountNumbers
{
    public class countNumbers
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        static void ReceiveInput()
        {
            var input = Console.ReadLine();
            CreateList(input);
        }

        static void CreateList(string input)
        {
            List<double> numList = new List<double>();

            numList = input.Split(' ').Select(x => double.Parse(x)).ToList();
            SortList(numList);
        }

        static void SortList(List<double> numList)
        {
            var checker = 0.0;
            var counter = 0;
            SortedDictionary<double, int> finalDictionary = new SortedDictionary<double, int>();

            for (var index = 0; index <= numList.Count - 1; index++)
            {
                checker = numList[index];

                foreach (var num in numList)
                {
                    if (num == checker)
                    {
                        counter++;
                    }
                }

                CreateDictionary(checker, counter, finalDictionary);
                numList.RemoveAll(z => z == checker);
                index -= 1;
                checker = 0;
                counter = 0;             
            }

            Print(finalDictionary);
        }

        static void CreateDictionary(double checker, int counter, SortedDictionary<double, int> finalDictionary)
        {
            finalDictionary.Add(checker, counter);
        }

        static void Print(SortedDictionary<double, int> finalDictionary)
        {
            foreach (var key in finalDictionary)
            {
                Console.WriteLine(key.Key + " -> " + key.Value);
            }
        }
    }
}
