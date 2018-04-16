using System;

namespace _03_Lab_ExactSumOfRealNumbers
{
    public class exactSumOfRealNumber
    {
        public static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            var sum = 0M;

            for (var numbers = 1; numbers <= input; numbers++)
            {
                var num = decimal.Parse(Console.ReadLine());

                sum = sum + num;
            }

            Console.WriteLine(sum);
        }
    }
}
