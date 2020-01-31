using System;
using System.Linq;

namespace Lab_04_AddVAT
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ReceiveInput();
        }

        private static void ReceiveInput()
        {
            var numbers = Console.ReadLine().Split(new char[] { ',', ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(n => double.Parse(n)).ToArray();

            Calculate(numbers);
        }

        private static void Calculate(double[] numbers)
        {
            for (var index = 0; index < numbers.Length; index++)
            {
                var price = numbers[index] + (numbers[index] * 20 / 100);
                Print(price);
            }
        }

        private static void Print(double price)
        {
            Console.WriteLine(string.Format("{0:0.00}",price));
        }
    }
}
