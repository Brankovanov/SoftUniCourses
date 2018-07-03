using System;
using System.Linq;
using System.Text;

namespace Lab_03_GroupNumbers
{
    public class GroupNumbers
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives input from the console.
        static void ReceiveInput()
        {
            var numbers = Console.ReadLine().Split(',').Select(x => int.Parse(x.Trim())).ToArray();
            SortNumber(numbers);
        }

        //Sorts numbers.
        static void SortNumber(int[] numbers)
        {
            var remainderZero = new StringBuilder();
            var remainderOne = new StringBuilder();
            var remainderTwo = new StringBuilder();

            foreach (var num in numbers)
            {
                if (Math.Abs(num) % 3 == 0)
                {
                    remainderZero.Append(num);
                    remainderZero.Append(" ");
                }
                else if (Math.Abs(num) % 3 == 1)
                {
                    remainderOne.Append(num);
                    remainderOne.Append(" ");
                }
                else if (Math.Abs(num) % 3 == 2)
                {
                    remainderTwo.Append(num);
                    remainderTwo.Append(" ");
                }
            }

            CreateJagged(remainderZero, remainderOne, remainderTwo);
        }

        //Creates the sorted array of numbers.
        static void CreateJagged(StringBuilder remainderZero, StringBuilder remainderOne, StringBuilder remainderTwo)
        {
            var tempZero = remainderZero.ToString().Split(' ');
            var tempOne = remainderOne.ToString().Split(' ');
            var tempTwo = remainderTwo.ToString().Split(' ');

            var jaggedOutput = new string[3][];

            jaggedOutput[0] = new string[tempZero.Length];

            for (var zero = 0; zero < tempZero.Length; zero++)
            {
                jaggedOutput[0][zero] = tempZero[zero];
            }

            jaggedOutput[1] = new string[tempOne.Length];

            for (var one = 0; one < tempOne.Length; one++)
            {
                jaggedOutput[1][one] = tempOne[one];
            }

            jaggedOutput[2] = new string[tempTwo.Length];

            for (var two = 0; two < tempTwo.Length; two++)
            {
                jaggedOutput[2][two] = tempTwo[two];
            }

            PrintJagged(jaggedOutput);
        }

        //Prints the grouped numbers.
        static void PrintJagged(string[][] jaggedOutput)
        {
            foreach (var number in jaggedOutput)
            {
                Console.WriteLine(string.Join(" ", number));
            }
        }
    }
}