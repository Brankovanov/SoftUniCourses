using System;
using System.Linq;

namespace Exercise_06_ExcludeAndReverse
{
    public class ExcludeAndReverse
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives input from the console.
        public static void ReceiveInput()
        {
            var numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();
            var checker = int.Parse(Console.ReadLine());
            Execute(numbers, checker);
        }

        //Checks wich numbers are excluded and prints the remaining reversed.
        public static void Execute(int[] numbers, int checker)
        {
            Predicate<int> check = n => n != 0;

            foreach (var number in numbers.Reverse())
            {
                if (check(number % checker))
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}