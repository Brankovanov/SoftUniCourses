using System;
using System.Linq;

namespace Exercise_01_LargestCommonEnd
{
    public class largestCommonEnd
    {
        public static void Main(string[] args)
        {
            Input();
        }

        static void Input()
        {
            var firstArray = Console.ReadLine().Split(' ');
            var secondArray = Console.ReadLine().Split(' ');

            var forwardCounter = 0;
            var backwardCounter = 0;

            CompareArraysForward(firstArray, secondArray, forwardCounter, backwardCounter);
        }

        static void CompareArraysForward(string[] firstArray, string[] secondArray, int forwardCounter, int backwardCounter)
        {
            if (firstArray.Length >= secondArray.Length)
            {
                for (var index = 0; index <= secondArray.Length - 1; index++)
                {
                    if (firstArray[index].Equals(secondArray[index]))
                    {
                        forwardCounter++;
                    }
                }
            }
            else if (firstArray.Length < secondArray.Length)
            {
                for (var index = 0; index <= firstArray.Length - 1; index++)
                {
                    if (firstArray[index].Equals(secondArray[index]))
                    {
                        forwardCounter++;
                    }
                }
            }

            CompareArrayBackward(firstArray, secondArray, forwardCounter, backwardCounter);
        }

        static void CompareArrayBackward(string[] firstArray, string[] secondArray, int forwardCounter, int backwardCounter)
        {
            Array.Reverse(firstArray);
            Array.Reverse(secondArray);

            if (firstArray.Length >= secondArray.Length)
            {
                for (var index = 0; index <= secondArray.Length - 1; index++)
                {
                    if (firstArray[index].Equals(secondArray[index]))
                    {
                        backwardCounter++;
                    }
                }
            }
            else if (firstArray.Length < secondArray.Length)
            {
                for (var index = 0; index <= firstArray.Length - 1; index++)
                {
                    if (firstArray[index].Equals(secondArray[index]))
                    {
                        backwardCounter++;
                    }
                }
            }

            Output(forwardCounter, backwardCounter);
        }

        static void Output(int forwardCounter, int backwardCounter)
        {
            if (forwardCounter <= backwardCounter)
            {
                Console.WriteLine(backwardCounter);
            }
            else if (backwardCounter < forwardCounter)
            {
                Console.WriteLine(forwardCounter);
            }
        }
    }
}
