using System;
using System.Collections.Generic;

namespace Exercise_03_PeriodicTable
{
    public class periodicTable
    {
        public static void Main(string[] args)
        {
            ReceiveChemicalCompaunds();
        }

        //Receives the formulas of the chemical compaunds from the console.
        static void ReceiveChemicalCompaunds()
        {
            var chemicals = new SortedSet<string>();
            var numberOfChemicalCompaunds = int.Parse(Console.ReadLine());

            for (var index = 1; index <= numberOfChemicalCompaunds; index++)
            {
                var chemicalCompaunds = Console.ReadLine().Split(' ');
                RecordUniqueIngrediants(chemicals, chemicalCompaunds);
            }

            PrintUniqueIngrediants(chemicals);
        }

        //Records the unique chemicals used in the chemical compounds.
        static void RecordUniqueIngrediants(SortedSet<string> chemicals, string[] chemicalCompaunds)
        {
            foreach (var chem in chemicalCompaunds)
            {
                chemicals.Add(chem);
            }
        }

        //Prints the unique chemicals found.
        static void PrintUniqueIngrediants(SortedSet<string> chemicals)
        {
            foreach (var c in chemicals)
            {
                Console.Write(c + " ");
            }
        }
    }
}