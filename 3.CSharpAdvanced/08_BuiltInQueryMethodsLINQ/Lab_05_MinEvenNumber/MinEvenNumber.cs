using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_05_MinEvenNumber
{
    public class MinEvenNumber
    {
        public static void Main(string[] args)
        {
            ReceiveNumbers();
        }

        //Receives numbers from the consoles.
        public static void ReceiveNumbers()
        {
            var numbersCollection = Console.ReadLine().Split(' ').Select(n => double.Parse(n)).ToList();
            FindMinEvenNum(numbersCollection);
        }

        //Finds the min even numbers in the collection.
        public static void FindMinEvenNum(List<double> numbersCollection)
        {
            var minEven = 0.0;

            if (numbersCollection.Any(e => e % 2 == 0))
            {
                minEven = numbersCollection.Where(n => n % 2 == 0).Min();
                Print(minEven);
            }
            else
            {
                Console.WriteLine("No match");
            }
        }

        //Prints the min even number.
        public static void Print(double minEven)
        {
            Console.WriteLine(string.Format("{0:0.00}", minEven));
        }
    }
}