using System;
using System.Collections.Generic;

namespace _01_Exercise_PracticeInt
{
    public class practiceInt
    {
        public static void Main(string[] args)
        {
            var num = new List<long>()
            {
                -100,128,-3540,64876,2147483648,-1141583228,-1223372036854775808
            };

            foreach(var n in num)
            {
                Console.WriteLine(n);
            }
        }
    }
}
