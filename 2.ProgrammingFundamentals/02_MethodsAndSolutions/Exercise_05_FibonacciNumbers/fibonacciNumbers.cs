using System;

namespace Exercise_05_FibonacciNumbers
{
    public class fibonacciNumbers
    {
        public static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            Console.WriteLine(Fibonacci(input));
        }

        static int Fibonacci(int input)
        {
            var firstNumber = 1;
            var secondNumber = 1;
            var output = 0;

            if (input <= 1)
            {
                return output = 1;
            }
            for (var num = 1; num < input; num++)
            {
                output = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = output;
            }

            return output;
        }
    }
}
