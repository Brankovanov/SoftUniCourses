using System;

namespace _11_Exercise_RectangleProperties
{
    public class rectangleProperties
    {
        public static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var perimeter = 2 * (width + height);
            var area = width * height;
            var diagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}
