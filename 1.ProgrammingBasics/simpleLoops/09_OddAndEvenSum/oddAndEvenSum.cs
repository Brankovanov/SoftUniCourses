using System;

namespace _09_OddAndEvenSum
{
    public class oddAndEvenSum
    {
        public static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var num = 0;
            var sumEven = 0;
            var sumOdd = 0;

            for (var n = 1; n <= input; n++)
            {
                num = int.Parse(Console.ReadLine());

                if (n % 2 == 0)
                {
                    sumEven = sumEven + num;
                }
                else
                {
                    sumOdd = sumOdd + num;
                }
            }

            if (sumEven == sumOdd)
            {
                Console.WriteLine("Yes, Sum = " + sumEven);
            }
            else
            {
                Console.WriteLine("No, Diff = " + Math.Abs(sumEven - sumOdd));
            }
        }
    }
}

