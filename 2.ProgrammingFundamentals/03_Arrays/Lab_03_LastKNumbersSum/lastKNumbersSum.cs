using System;

namespace Lab_03_LastKNumbersSum
{
    public class lastKNumbersSum
    {
        public static void Main(string[] args)
        {
            var numberOfElements = 0L;
            var numbersToSum = 0L;

            Input(numberOfElements, numbersToSum);
        }

        static void Input(long numberOfElements, long numbersToSum)
        {
            numberOfElements = long.Parse(Console.ReadLine());
            numbersToSum = long.Parse(Console.ReadLine());

           
            GenerateArray(numberOfElements, numbersToSum);
        }

        static void GenerateArray(long numberOfElements, long numbersToSum)
        {
            if (numberOfElements > numbersToSum)
            {
                long[] arrayOfElements = new long[numberOfElements];

                GenerateElements(numberOfElements, numbersToSum, arrayOfElements);
            }
            else
            {
                long[] arrayOfElements = new long[numbersToSum];

                GenerateElements( numberOfElements, numbersToSum, arrayOfElements);
            }
        }

        static void GenerateElements(long numberOfElements, long numbersToSum, long[] arrayOfElements)
        {
            var firstNum = 1L;
            arrayOfElements[0] = firstNum;

            for (var element = 1; element <= numberOfElements - 1; element++)
            {
                arrayOfElements[element] = CalculateNextNumber(element, firstNum, arrayOfElements, numbersToSum);
            }

            PrintArray(arrayOfElements);
        }

        static long CalculateNextNumber(long element, long firstNum, long[] arrayOfElements, long numbersToSum)
        {
            if (numbersToSum >= element)
            {
                for (var step = 1; step < numbersToSum; step++)
                {
                    firstNum += arrayOfElements[step];
                }
            }
            else
            {
                firstNum = 0L;

                for (var step = element - numbersToSum; step < element; step++)
                {
                    firstNum += arrayOfElements[step];
                }
            }

            return firstNum;
        }

        static void PrintArray(long[] arrayOfElements)
        {
            foreach (var n in arrayOfElements)
            {
                if(n!=0)
                {
                    Console.Write(n + " ");
                }
            }
        }
    }
}
