using System;
using System.Linq;

namespace Lab_04_TrippleSum
{
    public class trippleSum
    {
        public static void Main(string[] args)
        {
            GenerateArray();
        }

        static void GenerateArray()
        {
            var input = Console.ReadLine();

            var numbersArray = input.Split(' ').Select(s => int.Parse(s)).ToArray();

            CheckTrippleSum(numbersArray);
        }

        static void CheckTrippleSum(int[] numbersArray)
        {
            var checker = false;

            for (var position = 0; position <= numbersArray.Length - 1; position++)
            {
                for (var secondPosition = position + 1; secondPosition <= numbersArray.Length - 1; secondPosition++)
                {
                    var a = numbersArray[position];
                    var b = numbersArray[secondPosition];
                    var trippleSum = a + b;

                    if (numbersArray.Contains(trippleSum))
                    {
                        FindEquals(trippleSum, numbersArray, a, b);
                        checker = true;
                    }
                }
            }

            if (checker == false)
            {
                Console.WriteLine("No");
            }
        }

        static void FindEquals(int trippleSum, int[] numbersArray, int a, int b)
        {
            Console.WriteLine($"{a} + {b} == {trippleSum}");
        }
    }
}
