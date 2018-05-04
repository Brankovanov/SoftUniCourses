using System;

namespace Lab_02_ReverseArrayOfInt
{
    public class reverseArrayOfInt
    {
        public static void Main(string[] args)
        {
            var numberOfElements = int.Parse(Console.ReadLine());

            int[] arrayOfNumbers = new int[numberOfElements];

            GetArray(arrayOfNumbers, numberOfElements);
        }

        static void GetArray(int[] arrayOfNumbers, int numberOfElements)
        {
            for (var num = 0; num <= numberOfElements - 1; num++)
            {
                var numbers = int.Parse(Console.ReadLine());

                arrayOfNumbers[num] = numbers;
            }

            ReverseArray(arrayOfNumbers);
        }

        static void ReverseArray(int[] arrayOfNumbers)
        {
            Array.Reverse(arrayOfNumbers);

            PrintArray(arrayOfNumbers);
        }

        static void PrintArray(int[] arrayOfNumbers)
        {
            foreach (var n in arrayOfNumbers)
            {
                Console.Write(n + " ");
            }
        }
    }
}
