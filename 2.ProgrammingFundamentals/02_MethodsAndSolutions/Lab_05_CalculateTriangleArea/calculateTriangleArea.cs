using System;

namespace Lab_05_CalculateTriangleArea
{
    public class calculateTriangleArea
    {
        public static void Main(string[] args)
        {
            var triangleBase = double.Parse(Console.ReadLine());
            var triangleHeight = double.Parse(Console.ReadLine());

            var area = TriangleArea(triangleBase, triangleHeight);

            Console.WriteLine(area);
        }

        static double TriangleArea(double triangleBase, double triangleHeight)
        {

            return (triangleBase * triangleHeight) / 2;
        }
    }
}
