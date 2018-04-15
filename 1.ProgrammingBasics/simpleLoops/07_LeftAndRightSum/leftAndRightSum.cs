using System;

namespace _07_LeftAndRightSum
{
    public class leftAndRightSum
    {
        public static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var num1 = 0;
            var num2 = 0;
            var sum = 0;
            var sum2 = 0;

            for (var n = 1; n <= input; n++)
            {
                num1 = int.Parse(Console.ReadLine());

                sum = sum + num1;
            }

            for (var m = 1; m <= input; m++)
            {
                num2 = int.Parse(Console.ReadLine());

                sum2 = sum2 + num2;
            }

            if (sum == sum2)
            {
                Console.WriteLine("Yes, sum = " + sum);
            }
            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(sum - sum2));
            }
        }
    }
}
