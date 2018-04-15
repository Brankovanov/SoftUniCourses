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
            var belowTwoHnd = 0.0;
            var fromTwoHndToThreeHND99 = 0.0;
            var fromFourHndToFiveHnd99 = 0.0;
            var fromSixHndToSevenHnd99 = 0.0;
            var aboveEightHnd = 0.0;
            var p1 = 0.0;
            var p2 = 0.0;
            var p3 = 0.0;
            var p4 = 0.0;
            var p5 = 0.0;

            for (var line = 1; line <= n; line++)
            {
                number = int.Parse(Console.ReadLine());
                listOfNumbers.Add(number);
                number = 0;
            }

            foreach (var num in listOfNumbers)
            {
                if (num < 200)
                {
                    belowTwoHnd++;
                }
                else if (num > 199 && num <= 399)
                {
                    fromTwoHndToThreeHND99++;
                }
                else if (num > 399 && num <= 599)
                {
                    fromFourHndToFiveHnd99++;
                }
                else if (num > 599 && num <= 799)
                {
                    fromSixHndToSevenHnd99++;
                }
                else if (num >= 800)
                {
                    aboveEightHnd++;
                }
            }

            if (belowTwoHnd != 0)
            {
                p1 = (belowTwoHnd * 100) / n;
            }
            else
            {
                p1 = 0.0;
            }

            if (fromTwoHndToThreeHND99 != 0)
            {
                p2 = ( fromTwoHndToThreeHND99 * 100)/n;
            }
            else
            {
                p2 = 0.0;
            }

            if (fromFourHndToFiveHnd99 != 0)
            {
                p3 = (fromFourHndToFiveHnd99 * 100 )/ n;
            }
            else
            {
                p3 = 0.0;
            }

            if (fromSixHndToSevenHnd99 != 0)
            {
                p4 = (fromSixHndToSevenHnd99 * 100 )/ n;
            }
            else
            {
                p4 = 0.0;
            }

            if (aboveEightHnd != 0)
            {
                p5 = (aboveEightHnd * 100 )/ n ;
            }
            else
            {
                p5 = 0.0;
            }

            Console.WriteLine("{0:F2}" + "%", p1);
            Console.WriteLine("{0:F2}" + "%", p2);
            Console.WriteLine("{0:F2}" + "%", p3);
            Console.WriteLine("{0:F2}" + "%", p4);
            Console.WriteLine("{0:F2}" + "%", p5);
        }
    }
}

