using System;

namespace _07_GreatestCommonDeviser
{
    public class greatestCommonDeviser
    {
        public static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            var commonDivisor = 0;

            for (var div = 1; div <= a; div++)
            {
                if (a % div == 0)
                {
                    if (b % div == 0)
                    {
                        commonDivisor = div;
                    }
                }
            }

            Console.WriteLine(commonDivisor);
        }
    }
}
