using System;
using System.Linq;

namespace Exercise_04_EvenOrOdd
{
    public class EvenOrOdd
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives input from the console.
        public static void ReceiveInput()
        {
            var range = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();
            var command = Console.ReadLine();
            SortTheNumbers(range, command);
        }

        //Sorts the numbers according the command.
        public static void SortTheNumbers(int[] range, string command)
        {
            Func<int[], Predicate<int>, string> findEvenOdd = EvenOdd;
            Predicate<string> commandCheck = s => s.Equals("even");

            if (commandCheck(command))
            {
                Predicate<int> even = n => n == 0;
                Console.WriteLine(findEvenOdd(range, even));
            }
            else
            {
                Predicate<int> odd = n => n != 0;
                Console.WriteLine(findEvenOdd(range, odd));
            }
        }

        //Sorts the numbers according to the command received.
        private static string EvenOdd(int[] range, Predicate<int> comparer)
        {
            var output = string.Empty;

            for (var number = range[0]; number <= range[1]; number++)
            {
                if (comparer(number % 2))
                {
                    output += number.ToString() + " ";
                }
            }

            return output;
        }
    }
}