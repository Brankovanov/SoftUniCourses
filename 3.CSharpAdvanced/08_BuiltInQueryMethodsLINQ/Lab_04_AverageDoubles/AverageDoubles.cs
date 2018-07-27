using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_04_AverageDoubles
{
    public class AverageDoubles
    {
        public static void Main(string[] args)
        {
            ReceiveDoubles();
        }

        //Receives a collection of doubles from the console.
        public static void ReceiveDoubles()
        {
            var doubleCollection = Console.ReadLine().Split(' ').Select(n => double.Parse(n)).ToList();
            FindAverage(doubleCollection);
        }

        //Finds the average from the doubles in the collection.
        public static void FindAverage(List<double> doubleCollection)
        {
            var average = doubleCollection.Sum() / doubleCollection.Count;
            PrintAverage(average);
        }

        //Prints the average of the doubles in the collection.
        public static void PrintAverage(double average)
        {
            Console.WriteLine(string.Format("{0:0.00}", average));
        }
    }
}