using System;
using System.Linq;

namespace Lab_09_ExtractElements
{
    public class extractElements
    {
        public static void Main(string[] args)
        {
            Input();
        }

        static void Input()
        {
            var numberArray = Console.ReadLine().Split(' ');

            Extract(numberArray);
        }

        static void Extract(string[] numberArray)
        {


            if (numberArray.Length == 1)
            {
                PrintOneNumber(numberArray);
            }
            else if ((numberArray.Length) % 2 == 0)
            {
                var split = numberArray.Length / 2;

                PrintEvenNumber(numberArray, split);
            }
            else if ((numberArray.Length) % 2 != 0 && numberArray.Length > 1)
            {
                var split = numberArray.Length / 2;

                PrintOddNumber(numberArray, split);
            }
        }

        static void PrintOneNumber(string[] numberArray)
        {
            Console.WriteLine("{ " + numberArray[0].ToString() + " }");
        }

        static void PrintEvenNumber(string[] numberArray, int split)
        {
            Console.WriteLine("{ " + numberArray[split - 1].ToString() + ", " + numberArray[split].ToString() + " }");
        }

        static void PrintOddNumber(string[] numberArray, int split)
        {
            Console.WriteLine("{ " + numberArray[split - 1].ToString() + ", " + numberArray[split].ToString() + ", " + numberArray[split + 1].ToString() + " }");
        }
    }
}
