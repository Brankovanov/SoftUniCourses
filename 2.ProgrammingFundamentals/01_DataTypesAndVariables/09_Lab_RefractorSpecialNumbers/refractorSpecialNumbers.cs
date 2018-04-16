using System;

namespace _09_Lab_RefractorSpecialNumbers
{
    public class refractorSpecialNumbers
    {
        public static void Main(string[] args)
        {
            var range = int.Parse(Console.ReadLine());

            var sum = 0;
            var number = 0;
            var checker = false;

            for (var digit = 1; digit <= range; digit++)
            {
                number = digit;

                while (digit > 0)
                {
                    sum += digit % 10;
                    digit = digit / 10;
                }

                if (checker = sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{number} -> {checker}");
                }
                else
                {
                    Console.WriteLine($"{number} -> {checker}");
                }

                sum = 0;
                digit = number;
            }
        }
    }
}
