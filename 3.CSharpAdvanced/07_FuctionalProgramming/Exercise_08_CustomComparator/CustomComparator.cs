using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_08_CustomComparator
{
    public class CustomComparator
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives numbers from the console.
        public static void ReceiveInput()
        {
            var numbers = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
            Predicate<int> checkerEven = n => n == 0;
            Predicate<int> checkerOdd = n => n != 0;
            Func<int[], Predicate<int>, List<int>> sort = Sort;
            var even = sort(numbers, checkerEven);
            var odd = sort(numbers, checkerOdd);
            Print(even, odd);
        }

        //Sorts numbers.
        private static List<int> Sort(int[] numbers, Predicate<int> checker)
        {
            var temp = new List<int>();

            foreach (var num in numbers)
            {
                if (checker(num % 2))
                {
                    temp.Add(num);
                }
            }

            return temp;
        }

        //Prints and sorts the numbers.
        public static void Print(List<int> even, List<int> odd)
        {
            var output = string.Join(" ", even.OrderBy(n => n)) + " " + string.Join(" ", odd.OrderBy(n => n));
            Console.WriteLine(output);
        }
    }
}