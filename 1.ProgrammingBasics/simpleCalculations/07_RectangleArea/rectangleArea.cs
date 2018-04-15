using System;

namespace _07_RectangleArea
{
    public class rectangleArea
    {
        public static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var a = x1 - x2;
            var b = y1 - y2;
            var area = Math.Abs(a) * Math.Abs(b);
            var perimeter = Math.Abs(a) + Math.Abs(a) + Math.Abs(b) + Math.Abs(b);

            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}
