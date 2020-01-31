using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_01_SortEvenNumbers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ReceiveInput();
        }

        private static void ReceiveInput()
        {
            var numbers = Console.ReadLine().Split(new char[] { ',', ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();

            SortNumbers(numbers);
        }

        private static void SortNumbers(int[] numbers)
        {
            var sortedList = new List<int>();

            for(var index = 0; index<numbers.Length;index++)
            {
                if(numbers[index]%2==0)
                {
                    sortedList.Add(numbers[index]);
                }
            }

            Print(sortedList);
        }

        private static void Print(List<int> sortedList)
        {
            Console.WriteLine(string.Join(", ", sortedList.OrderBy(n => n)));
        }
    }
}
