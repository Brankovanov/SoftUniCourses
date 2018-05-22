using System;
using System.Numerics;

namespace Lab_03_BigFactorial
{
    public class bigFactorial
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Получава входни данни.
        static void ReceiveInput()
        {
            BigInteger input = BigInteger.Parse(Console.ReadLine());

            Calculate(input);
        }

        //Извиква клас Factorial.
        static void Calculate(BigInteger input)
        {
            Factorial firstFactorial = new Factorial(input);
            firstFactorial.N = input;

            firstFactorial.CalculateFactorial();
        }
    }

    //Изчислява факториал на входното число.
    public class Factorial
    {
        private BigInteger n;

        public BigInteger N
        {
            get
            {
                return this.n;
            }
            set
            {
                this.n = value;
            }
        }

        public Factorial(BigInteger input)
        {
            this.n = input;
        }

        public void CalculateFactorial()
        {
            BigInteger factorial = 1;

            for (var index = 1; index <= n; index++)
            {
                factorial *= index;
            }

            Console.WriteLine(factorial);
        }
    }
}
