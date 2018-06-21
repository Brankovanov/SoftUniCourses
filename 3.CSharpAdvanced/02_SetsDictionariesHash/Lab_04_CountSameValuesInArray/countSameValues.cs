using System;
using System.Collections.Generic;

namespace Lab_04_CountSameValuesInArray
{
    public class countSameValues
    {
        public static void Main(string[] args)
        {
            ReceiveValues();
        }

        //Receives the values from the console.
        static void ReceiveValues()
        {
            var valuesArray = Console.ReadLine().Split(' ');
            CountValues(valuesArray);
        }

        //Counts the number of occurrences of unique values.
        static void CountValues(string[] valuesArray)
        {
            var numberOfOccurrences = new SortedDictionary<string, int>();

            foreach (var value in valuesArray)
            {
                if (numberOfOccurrences.ContainsKey(value))
                {
                    numberOfOccurrences[value]++;
                }
                else
                {
                    numberOfOccurrences.Add(value, 1);
                }
            }

            PrintUniqueOccurrences(numberOfOccurrences);
        }

        //Prints number of unique occurrences.
        static void PrintUniqueOccurrences(SortedDictionary<string, int> numberOfOccurrences)
        {
            foreach (var occurrence in numberOfOccurrences)
            {
                Console.WriteLine(occurrence.Key + " - " + occurrence.Value + " times");
            }
        }
    }
}