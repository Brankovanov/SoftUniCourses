using System;
using System.Collections.Generic;

namespace _14_Histogram
{
    public class histogram
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var number = 0;
            var listOfNumbers = new List<int>();
            var divideByTwo = 0.0;
            var divideByThree = 0.0;
            var divideByFive = 0.0;
            var p1 = 0.0;
            var p2 = 0.0;
            var p3 = 0.0;

            for (var line = 1; line <= n; line++)
            {
                number = int.Parse(Console.ReadLine());
                listOfNumbers.Add(number);
                number = 0;
            }

            foreach (var num in listOfNumbers)
            {
                if (num % 2 == 0)
                {
                    divideByTwo++;
                }

                if (num % 3 == 0)
                {
                    divideByThree++;
                }

                if (num % 4 == 0)
                {
                    divideByFive++;
                }
            }

            if (divideByTwo != 0)
            {
                p1 = (divideByTwo * 100) / n;
            }
            else
            {
                p1 = 0.0;
            }

            if (divideByThree != 0)
            {
                p2 = (divideByThree * 100) / n;
            }
            else
            {
                p2 = 0.0;
            }

            if (divideByFive != 0)
            {
                p3 = (divideByFive * 100) / n;
            }
            else
            {
                p3 = 0.0;
            }

            Console.WriteLine("{0:F2}" + "%", p1);
            Console.WriteLine("{0:F2}" + "%", p2);
            Console.WriteLine("{0:F2}" + "%", p3);
        }
    }
}

