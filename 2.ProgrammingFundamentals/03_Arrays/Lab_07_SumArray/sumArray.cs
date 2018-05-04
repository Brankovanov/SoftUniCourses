using System;
using System.Linq;

namespace Lab_07_SumArray
{
    public class sumArray
    {
        public static void Main(string[] args)
        {
            Input();
        }

        static void Input()
        {
            var firstArray = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            var secondArray = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();

            SumArrays(firstArray, secondArray);
        }

        static void SumArrays(int[] firstArray, int[] secondArray)
        {
            if (firstArray.Length == secondArray.Length)
            {
                SumEqualArrays(firstArray, secondArray);
            }
            else if (firstArray.Length < secondArray.Length)
            {
                SumFirstArrayShort(firstArray, secondArray);
            }
            else if (secondArray.Length < firstArray.Length)
            {
                SumSecondArrayShort(firstArray, secondArray);
            }
        }

        static void SumEqualArrays(int[] firstArray, int[] secondArray)
        {
            for (var index = 0; index <= firstArray.Length - 1; index++)
            {
                Console.Write(firstArray[index] + secondArray[index] + " ");
            }
        }

        static void SumFirstArrayShort(int[] firstArray, int[] secondArray)
        {
            try
            {
                var difference = 0;
                var rounds = secondArray.Length / firstArray.Length;

                for (var index = 0; index <= firstArray.Length - 1; index++)
                {
                    Console.Write(firstArray[index] + secondArray[index] + " ");
                }

                for (var secondaryIndex = 0; secondaryIndex <= rounds; secondaryIndex++)
                {
                    for (var thirdIndex = 0; thirdIndex <= firstArray.Length - 1; thirdIndex++)
                    {
                        Console.Write(firstArray[thirdIndex] + secondArray[firstArray.Length + difference] + " ");

                        difference++;

                        if (difference == secondArray.Length - firstArray.Length)
                        {
                            break;
                        }
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                return;
            }
        }

        static void SumSecondArrayShort(int[] firstArray, int[] secondArray)
        {
            try
            {
                var difference = 0;
                var rounds = firstArray.Length / secondArray.Length;

                for (var index = 0; index <= secondArray.Length - 1; index++)
                {
                    Console.Write(secondArray[index] + firstArray[index] + " ");
                }

                for (var secondaryIndex = 0; secondaryIndex <= rounds; secondaryIndex++)
                {
                    for (var thirdIndex = 0; thirdIndex <= secondArray.Length - 1; thirdIndex++)
                    {
                        Console.Write(secondArray[thirdIndex] + firstArray[secondArray.Length + difference] + " ");

                        difference++;

                        if (difference == firstArray.Length - secondArray.Length)
                        {
                            break;
                        }
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                return;
            }
        }
    }
}