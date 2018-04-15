using System;

namespace _04_EvenPowerOfTwo
{
    public class evenPowersOfTwo
    {
        public static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var two = 1;

            for (var n = 0; n <= input; n++)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine(two);
                    two = two * 2;
                }
                else
                {
                    two = two * 2;
                }
            }
        }
    }
}
