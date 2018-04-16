using System;

namespace _02_Lab_CircleArea
{
    public class circleArea
    {
        public static void Main(string[] args)
        {
            var radius = double.Parse(Console.ReadLine());

            var area = Math.PI * Math.Pow(radius,2);

            Console.WriteLine(Math.Round(area, 12));
        }
    }
}
