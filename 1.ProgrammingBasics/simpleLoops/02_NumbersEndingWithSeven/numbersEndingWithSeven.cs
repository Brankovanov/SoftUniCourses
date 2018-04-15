using System;

namespace _02_NumbersEndingWithSeven
{
    public class numbersEndingWithSeven
    {
        public static void Main(string[] args)
        {
            for (var n = 1; n <= 1000; n++)
            {
                if (n % 10 == 7)
                {
                    Console.WriteLine(n);
                }
            }
        }
    }
}
