using System;
using System.Linq;

namespace Exercise_03_MinFunction
{
    public class MinFunction
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives input from the console.
        public static void ReceiveInput()
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            Func<int[], int> findMin = FindTheSmallest;
            var smallnumber = findMin(input);
            PrintMin(smallnumber);
        }

        //Finds the smallest number in the collection.
        private static int FindTheSmallest(int[] input)
        {
            var min = input[0];

            foreach (var number in input)
            {
                if (min > number)
                {
                    min = number;
                }
            }

            return min;
        }

        //Prints the smallest number in the collection.
        public static void PrintMin(int smallNumber)
        {
            Console.WriteLine(smallNumber);
        }
    }
}