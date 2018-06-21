using System;
using System.Collections.Generic;

namespace Exercise_04_CountSymbols
{
    public class countSymbols
    {
        public static void Main(string[] args)
        {
            ReceiveString();
        }

        //Receives string from the console.
        static void ReceiveString()
        {
            var text = Console.ReadLine();
            CountValues(text);
        }

        //Counts the number of occurrences of symbols.
        static void CountValues(string text)
        {
            var numberOfOccurrences = new SortedDictionary<char, int>();

            foreach (var symbol in text)
            {
                if (numberOfOccurrences.ContainsKey(symbol))
                {
                    numberOfOccurrences[symbol]++;
                }
                else
                {
                    numberOfOccurrences.Add(symbol, 1);
                }
            }

            PrintUniqueOccurrences(numberOfOccurrences);
        }

        //Prints number of unique occurrences.
        static void PrintUniqueOccurrences(SortedDictionary<char, int> numberOfOccurrences)
        {
            foreach (var occurrence in numberOfOccurrences)
            {
                Console.WriteLine(occurrence.Key + ": " + occurrence.Value + " time/s");
            }
        }
    }
}