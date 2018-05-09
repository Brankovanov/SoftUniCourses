using System;
using System.Linq;

namespace Exercise_11_EqualSums
{
    public class equalSums
    {
        public static void Main(string[] args)
        {
            Input();
        }

        static void Input()
        {
            var input = Console.ReadLine();

            CreateArray(input);
        }

        static void CreateArray(string input)
        {
            var intArray = input.Split(' ').Select(x => int.Parse(x)).ToArray();

            FindSums(intArray);
        }

        static void FindSums(int[] intArray)
        {
            var answer = 0;
            var leftSum = 0;
            var rightSum = 0;
            var counter = 0;

            for (var index = 0; index <= intArray.Length - 1; index++)
            {
                answer = index;

                for (var leftIndex = index - 1; leftIndex >= 0; leftIndex--)
                {
                    leftSum += intArray[leftIndex];
                }

                for (var rightIndex = index + 1; rightIndex <= intArray.Length - 1; rightIndex++)
                {
                    rightSum += intArray[rightIndex];
                }

                if (leftSum == rightSum)
                {
                    counter++;
                    leftSum = 0;
                    rightSum = 0;

                    Console.WriteLine(answer);

                    answer = 0;
                }
                else
                {
                    leftSum = 0;
                    rightSum = 0;
                    answer = 0;
                }
            }

            if (counter == 0)
            {
                Console.Write("no");
            }
        }
    }
}
