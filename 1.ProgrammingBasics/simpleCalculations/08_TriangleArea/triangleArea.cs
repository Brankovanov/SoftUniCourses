using System;

namespace _08_TriangleArea
{
    public class triangleArea
    {
        public static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var area = (a * h) / 2;

            Console.WriteLine(area);
        }
    }
}
