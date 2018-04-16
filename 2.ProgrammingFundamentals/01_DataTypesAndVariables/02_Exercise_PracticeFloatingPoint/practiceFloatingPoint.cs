using System;
using System.Collections.Generic;

namespace _02_Exercise_PracticeFloatingPoint
{
    public class practiceFloatingPoint
    {
        public static void Main(string[] args)
        {
            var floatingNumber = new List<decimal>()
            { 3.141592653589793238m, 1.60217657m, 7.8184261974584555216535342341m };

            foreach(var n in floatingNumber)
            {
                Console.WriteLine(n);
            }
        }
    }
}
