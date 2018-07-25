using System;
using System.Linq;

namespace Lab_02_SumNumbers
{
    public class SumNumbers
    {
        public static void Main(string[] args)
        {
            ReceiveNumbers();
        }

        //Receives numbers from the console.
        public static void ReceiveNumbers()
        {
            var numbers = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();
            SumNumber(numbers);
        }

        //Sums the numbers.
        public static void SumNumber(int[] numbers)
        {
            var sum = 0;

            foreach (var num in numbers)
            {
                sum += num;
            }

            Print(sum, numbers);
        }

        //Prints the sum and the count of the numbers.
        public static void Print(int sum, int[] numbers)
        {
            Console.WriteLine(numbers.Length);
            Console.WriteLine(sum);
        }
    }
}