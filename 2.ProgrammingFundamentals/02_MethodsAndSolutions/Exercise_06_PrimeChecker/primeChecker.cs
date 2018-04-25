using System;

namespace Exercise_06_PrimeChecker
{
    public class primeChecker
    {
        public static void Main(string[] args)
        {
            var inputNumber = double.Parse(Console.ReadLine());

            CheckPrime(inputNumber);
        }

        static void CheckPrime(double inputNumber)
        {
            var check = 0;

            if (inputNumber <= 1)
            {
                Console.WriteLine("False");
            }
            else
            {
                for (var dev = 2; dev < inputNumber; dev++)
                {
                    if (inputNumber % dev == 0)
                    {
                        check++;
                        break;
                    }
                }

                if (check == 0)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
        }
    }
}