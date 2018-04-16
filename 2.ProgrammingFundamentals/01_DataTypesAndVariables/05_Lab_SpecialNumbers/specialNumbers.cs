using System;

namespace _05_Lab_SpecialNumbers
{
    public class specialNumbers
    {
        public static void Main(string[] args)
        {
            var range = int.Parse(Console.ReadLine());
            var sum = 0;

            for (var number = 1; number <= range; number++)
            {
                foreach (var digit in number.ToString())
                {
                    sum = sum + int.Parse(digit.ToString());
                }

                switch (sum)
                {
                    case 5:
                        Console.WriteLine(number + " -> True");
                        break;
                    case 7:
                        Console.WriteLine(number + " -> True");
                        break;
                    case 11:
                        Console.WriteLine(number + " -> True");
                        break;
                    default:
                        Console.WriteLine(number + " -> False");
                        break;
                }

                sum = 0;
            }
        }
    }
}
