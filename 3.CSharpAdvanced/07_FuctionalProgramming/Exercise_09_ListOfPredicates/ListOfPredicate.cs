using System;
using System.Linq;

namespace Exercise_09_ListOfPredicates
{
    public class ListOfPredicate
    {
        public static void Main(string[] args)
        {
            Receive();
        }

        //Receives the input from the console.
        public static void Receive()
        {
            var endBorder = int.Parse(Console.ReadLine());
            var predicates = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();
            SortNumbers(endBorder, predicates);
        }

        //Sorts the numbers.
        public static void SortNumbers(int endBorders, int[] predicates)
        {
            Func<int, int[], Predicate<int>, string> findNumbers = Execute;
            Predicate<int> checker = n => n == 0;
            var output = string.Empty;

            for (var num = 1; num <= endBorders; num++)
            {
                if (findNumbers(num, predicates, checker) != null)
                {
                    output += findNumbers(num, predicates, checker) + " ";
                }
            }

            Print(output);
        }

        //Checks if the number is deviseble by thee predicates.
        private static string Execute(int num, int[] predicates, Predicate<int> checker)
        {
            foreach (var pred in predicates)
            {
                if (!checker(num % pred))
                {
                    return null;
                }
            }

            return num.ToString();
        }

        //Prints the sorted numbers.
        public static void Print(string output)
        {
            Console.WriteLine(output);
        }
    }
}