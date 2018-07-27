using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_06_FindAndSumInt
{
    public class FindAndSumInt
    {
        public static void Main(string[] args)
        {
            ReceiveElements();
        }

        //Receieves a collection of elements from the console.
        public static void ReceiveElements()
        {
            var elements = Console.ReadLine().Split(' ').ToList();
            ParseAndSum(elements);
        }

        //Tries to parse the elements and sum the ints.
        public static void ParseAndSum(List<string> elements)
        {
            var sum = 0;

            foreach (var element in elements)
            {
                int.TryParse(element, out int s);
                sum += s;
            }

            Print(sum);
        }

        //Prints the sum of the int elements from the collection ot the console.
        public static void Print(int sum)
        {
            if (sum == 0)
            {
                Console.WriteLine("No match");
            }
            else
            {
                Console.WriteLine(sum);
            }
        }
    }
}