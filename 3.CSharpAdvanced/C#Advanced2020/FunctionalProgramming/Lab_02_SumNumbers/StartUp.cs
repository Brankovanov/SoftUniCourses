using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_02_SumNumbers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ReceiveInput();
        }

        private static void ReceiveInput()
        {
            var numbers = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();

            SortNumbers(numbers);
        }

        private static void SortNumbers(int[] numbers)
        {
            var sum = 0;
            var count = numbers.Length;

            for (var index = 0; index < count; index++)
            {
             
                    sum+=numbers[index];
              
            }

            Print(count, sum);
        }

        private static void Print(int count, int sum)
        {
            Console.WriteLine(count);
            Console.WriteLine(sum);
        }
    }
}
