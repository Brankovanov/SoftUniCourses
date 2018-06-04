using System;
using System.Numerics;

namespace Exercise_02_ConvertFromNToTen
{
    public class convertFromNtoTen
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Приема число в произволна бройна система и бройната система, в която е.
        static void ReceiveInput()
        {
            var input = Console.ReadLine().Split(' ');
            var number = input[1];
            var baseNumber = BigInteger.Parse(input[0]);
            var answer = new BigInteger();

            ConvertNumber(number, baseNumber, answer);
        }

        //Преобразува даденото число към варианта му в десетична бройна система.
        static void ConvertNumber(string number, BigInteger baseNumber, BigInteger answer)
        {
            for (var index = 0; index <= number.Length - 1; index++)
            {
                answer += (BigInteger.Parse(number[(number.Length - 1) - index].ToString()) * BigInteger.Pow(baseNumber, index));
            }

            PrintConvertedNumber(answer);
        }

        //Отпечатва конвертираното число.
        static void PrintConvertedNumber(BigInteger answer)
        {
            Console.WriteLine(answer);
        }
    }
}