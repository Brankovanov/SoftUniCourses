using System;
using System.Linq;

namespace Lab_01_SortEvenNumber
{
    public class SortEvenNumbers
    {
        public static void Main(string[] args)
        {
            ReceiveNumbers();
        }

        //Receives numbers from the console.
        public static void ReceiveNumbers()
        {
            var numbers = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();
            PrintEvenNumbers(numbers);
        }

        //Prints the even numbers from the array.
        public static void PrintEvenNumbers(int[] numbers)
        {
            Console.WriteLine(string.Join(", ", numbers.Where(n => n % 2 == 0).OrderBy(m => m)));
        }
    }
}