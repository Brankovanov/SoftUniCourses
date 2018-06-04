using System;
using System.Numerics;

namespace Exercise_01_ConvertFromTenToN
{
    public class convertFromTenToN
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Приема десетично число и бройната система, в която да го преобразуваме.
        static void ReceiveInput()
        {
            var input = Console.ReadLine().Split(' ');
            var number = BigInteger.Parse(input[1]);
            var baseNumber = BigInteger.Parse(input[0]);
            var answer = string.Empty;

            ConvertNumber(number, baseNumber, answer);
        }

        //Преобразува дадено число към варианта му в дадената бройна система.
        static void ConvertNumber(BigInteger number, BigInteger baseNumber, string answer)
        {
            while (number != 0)
            {
                answer = (number % baseNumber).ToString() + answer;
                number = number / baseNumber;
            }

            PrintConvertedNumber(answer);
        }

        //Отпечатва конвертираното число.
        static void PrintConvertedNumber(string answer)
        {
            Console.WriteLine(answer);
        }
    }
}
