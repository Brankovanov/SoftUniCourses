using System;

namespace Lab_02_SignOfIntegerNumber
{
    public class signOfIntegerNumber
    {
        public static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            SignOfNum(num);
        }

        static void SignOfNum(int num)
        {
            if (num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
            else if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if (num == 0)
            {
                Console.WriteLine($"The number {num} is zero.");
            }

        }
    }
}
