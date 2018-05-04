using System;

namespace Ecercise_05_CompareCharArray
{
    public class compareCharArray
    {
        public static void Main(string[] args)
        {
            Input();
        }

        static void Input()
        {
            var firstArray = Console.ReadLine().Split(' ');
            var secondArray = Console.ReadLine().Split(' ');

            Compare(firstArray, secondArray);
        }

        static void Compare(string[] firstArray, string[] secondArray)
        {
            CompareLenght(firstArray, secondArray);
        }

        static void CompareLenght(string[] firstArray, string[] secondArray)
        {
            if (firstArray.Length >= secondArray.Length)
            {
                FirstArrayLonger(firstArray, secondArray);
            }
            else if (firstArray.Length < secondArray.Length)
            {
                SecondArrayLonger(firstArray, secondArray);
            }
        }

        static void FirstArrayLonger(string[] firstArray, string[] secondArray)
        {
            for (var index = 0; index <= secondArray.Length - 1; index++)
            {
                if (firstArray[index].CompareTo(secondArray[index]) > 0)
                {
                    PrintSecond(secondArray);
                    Console.WriteLine();
                    PrintFirst(firstArray);

                    break;
                }
                else if (firstArray[index].CompareTo(secondArray[index]) < 0)
                {
                    PrintFirst(firstArray);
                    Console.WriteLine();
                    PrintSecond(secondArray);

                    break;
                }
                else if (firstArray[secondArray.Length - 1].CompareTo(secondArray[secondArray.Length - 1]) == 0 && index == secondArray.Length-1)
                {
                    PrintSecond(secondArray);
                    Console.WriteLine();
                    PrintFirst(firstArray);

                    break;
                }
            }
        }

        static void SecondArrayLonger(string[] firstArray, string[] secondArray)
        {
            for (var index = 0; index <= firstArray.Length - 1; index++)
            {
                if (firstArray[index].CompareTo(secondArray[index]) > 0)
                {
                    PrintSecond(secondArray);
                    Console.WriteLine();
                    PrintFirst(firstArray);

                    break;
                }
                else if (firstArray[index].CompareTo(secondArray[index]) < 0)
                {
                    PrintFirst(firstArray);
                    Console.WriteLine();
                    PrintSecond(secondArray);

                    break;
                }
                else if (firstArray[secondArray.Length - 1].CompareTo(secondArray[secondArray.Length - 1]) == 0 && index == firstArray.Length-1)
                {
                    PrintFirst(firstArray);
                    Console.WriteLine();
                    PrintSecond(secondArray);

                    break;
                }
            }
        }

        static void PrintSecond(string[] secondArray)
        {
            foreach (var ch in secondArray)
            {
                Console.Write(ch.ToString());
            }
        }

        static void PrintFirst(string[] firstArray)
        {
            foreach (var ch in firstArray)
            {
                Console.Write(ch.ToString());
            }
        }
    }
}
