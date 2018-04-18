using System;

namespace _16_Exercise_ComparingFloats
{
    public class comparingFloats
    {
        public static void Main(string[] args)
        {
            var numA = double.Parse(Console.ReadLine());
            var numB = double.Parse(Console.ReadLine());

            if (Math.Abs(numA) - Math.Abs(numB) < 0.000001)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
