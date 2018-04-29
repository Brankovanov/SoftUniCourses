using System;
using System.Linq;

namespace Exercise_12_MasterNumber
{
    public class masterNumber
    {
        public static void Main(string[] args)
        {
            var input = 0;

            input = InputRange(input);
            var number = 0;

            CycleRange(input, number);
        }

        static int InputRange(int input)
        {
            return int.Parse(Console.ReadLine());
        }

        static void CycleRange(int input, int number)
        {
            for (var n = 1; n <= input; n++)
            {
                number = n;

                CheckPalindrom(number);

                number = 0;
            }
        }

        static void CheckPalindrom(int number)
        {
            var charArray = number.ToString().ToCharArray().Reverse();
            var reversedInput = string.Empty;

            foreach (var ch in charArray)
            {
                reversedInput += ch;
            }

            if (number.ToString().Equals(reversedInput))
            {
                CheckDivideBySeven(number);
            }

            charArray = null;
            reversedInput = string.Empty;
        }

        static void CheckDivideBySeven(int number)
        {
            var sumOfDigits = 0;

            for (var digit = number; digit > 0; digit = digit / 10)
            {
                sumOfDigits += digit % 10;
            }

            if (sumOfDigits % 7 == 0)
            {
                CheckEvenDigits(number);
            }
        }

        static void CheckEvenDigits(int number)
        {
            var numberToCheck = 0;

            for (var dig = number; dig > 0; dig = dig / 10)
            {
                numberToCheck = dig % 10;

                if (numberToCheck % 2 == 0)
                {
                    Console.WriteLine(number);
                    return;
                }
                else
                {
                    numberToCheck = 0;
                }
            }
        }
    }
}
