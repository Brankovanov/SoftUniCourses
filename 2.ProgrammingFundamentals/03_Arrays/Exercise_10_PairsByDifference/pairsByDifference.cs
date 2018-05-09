using System;
using System.Linq;

namespace Exercise_10_PairsByDifference
{
    public class pairsByDifference
    {
        public static void Main(string[] args)
        {
            Input();
        }

        static void Input()
        {
            var inputArray = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            var difference = int.Parse(Console.ReadLine());

            CheckDifference(inputArray, difference);
        }

        static void CheckDifference(int[] inputArray, int difference)
        {
            var counter = 0;

            for (var index = 0; index <= inputArray.Length - 1; index++)
            {
                for (var innerIndex = 0; innerIndex <= inputArray.Length - 1; innerIndex++)
                {
                    if (inputArray[index] - inputArray[innerIndex] == difference)
                    {
                        counter++;
                    }
                }
            }

            Print(counter);
        }

        static void Print(int counter)
        {
            Console.WriteLine(counter);
        }
    }
}
