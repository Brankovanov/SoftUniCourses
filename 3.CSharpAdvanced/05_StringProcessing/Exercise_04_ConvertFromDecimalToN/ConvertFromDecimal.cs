using System;

namespace Exercise_04_ConvertFromDecimalToN
{
    public class ConvertFromDecimal
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
            var baseToConvert = int.Parse(temp[0]);
            var num = int.Parse(temp[1]);
            var output = string.Empty;

            while (num != 0)
            {
                output = (num % baseToConvert).ToString() + output;
                num = num / baseToConvert;
            }

            Print(output);
        }

        //Prints the output number. 
        public static void Print(string output)
        {
            Console.WriteLine(output);
        }
    }
}