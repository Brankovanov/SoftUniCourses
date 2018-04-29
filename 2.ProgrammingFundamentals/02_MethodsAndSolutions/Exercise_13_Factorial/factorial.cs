using System;
using System.Numerics;

namespace Exercise_13_Factorial
{
    public class factorial
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

        static void Factorial (int inputNumber)
        {
            BigInteger factorial = 1;
            
            for (var num = inputNumber; num>0; num--)
            {
                factorial *= num;
            }

            Console.Write(factorial);
        }
    }
}
