using System;
using System.Numerics;

namespace Exercise_14_FactorialTrailingZeros
{
    public class factorialTrailingZeros
    {
        public static void Main(string[] args)
        {
            var inputNumber = InputNumber();

            Factorial(inputNumber);
        }

        static int InputNumber()
        {
            return int.Parse(Console.ReadLine());
        }

        static void Factorial(int inputNumber)
        {
            BigInteger factorial = 1;

            for (var num = inputNumber; num > 0; num--)
            {
                factorial *= num;
            }

            CountZeros(factorial);
        }

        static void CountZeros(BigInteger factorial)
        {
            var counter = 0;

            for (var number = factorial; number > 0; number = number / 10)
            {
                if (number % 10 == 0)
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine(counter);

                    break;
                }
            }
        }
    }
}
