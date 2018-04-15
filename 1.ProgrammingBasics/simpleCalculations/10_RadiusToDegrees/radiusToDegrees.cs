using System;

namespace _10_RadiusToDegrees
{
    public class radiusToDegrees
    {
        public static void Main(string[] args)
        {
            var radians = double.Parse(Console.ReadLine());

            var degrees = radians * (180 / Math.PI);

            Console.WriteLine(Math.Round(degrees));
        }
    }
}
