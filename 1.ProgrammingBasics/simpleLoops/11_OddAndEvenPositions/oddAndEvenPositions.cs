using System;

namespace _11_OddAndEvenPositions
{
    public class oddAndEvenPositions
    {
        public static void Main(string[] args)
        {
            var input = double.Parse(Console.ReadLine());
            var evenSum = 0.0;
            var evenMax = double.MinValue;
            var evenMin = double.MaxValue;
            var oddSum = 0.0;
            var oddMax = double.MinValue;
            var oddMin = double.MaxValue;
            var num = 0.0;

            for (var i = 1; i <= input; i++)
            {
                num = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum = evenSum + num;

                    if (num > evenMax)
                    {
                        evenMax = num;
                    }

                    if (num < evenMin)
                    {
                        evenMin = num;
                    }
                }
                else if (i % 2 != 0)
                {
                    oddSum = oddSum + num;

                    if (num > oddMax)
                    {
                        oddMax = num;
                    }

                    if (num < oddMin)
                    {
                        oddMin = num;
                    }
                }

                num = 0;
            }


            Console.WriteLine("OddSum=" + oddSum + " ,");

            if (oddMin == double.MaxValue)
            {
                Console.WriteLine("OddMin=No" + " ,");
            }
            else
            {
                Console.WriteLine("OddMin=" + oddMin + " ,");
            }

            if (oddMax == double.MinValue)
            {
                Console.WriteLine("OddMax=No" + " ,");
            }
            else
            {
                Console.WriteLine("OddMax=" + oddMax + " ,");
            }

            Console.WriteLine("EvenSum=" + evenSum + " ,");

            if (evenMin == double.MaxValue)
            {
                Console.WriteLine("EvenMin=No" + " ,");
            }
            else
            {
                Console.WriteLine("EvenMin=" + evenMin + " ,");
            }

            if (evenMax == double.MinValue)
            {
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine("EvenMax= " + evenMax);
            }

        }
    }
}
