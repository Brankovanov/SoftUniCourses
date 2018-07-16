using System;
using System.Numerics;

namespace Exercise_05_ConvertFromBaseNToDecimal
{
    public class ConvertFromBaseNToDecimal
    {
        public static void Main(string[] args)
        {
            ReceiveNumbers();
        }

        //Receives numbers from the console.
        public static void ReceiveNumbers()
        {
            var numbers = Console.ReadLine();
            ConvertNumber(numbers);
        }

        //Converts decimal numbers to n-base number.
        public static void ConvertNumber(string numbers)
        {
            var temp = numbers.Split(' ');
            var baseOrigin = BigInteger.Parse(temp[0]);
            var num = temp[1];
            var output = new BigInteger();

            for (var index = 0; index <= num.Length - 1; index++)
            {
                output += (BigInteger.Parse(num[(num.Length - 1) - index].ToString()) * BigInteger.Pow(baseOrigin, index));
            }

            Print(output);
        }

        //Prints the output number. 
        public static void Print(BigInteger output)
        {
            Console.WriteLine(output);
        }
    }
}