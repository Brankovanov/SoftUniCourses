using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Point_Rectangle
{
    public class StartUp
    {
        static void Main()
        {
            ReceiveInput();
        }

        public static void ReceiveInput()
        {
            var rectangleCoordinates = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToList();

            var rectangle = CreateRectangle(rectangleCoordinates);

            var numberOfPoints = int.Parse(Console.ReadLine());

            for (var p = 1; p <= numberOfPoints; p++)
            {
                var outerPointCoordinates = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x)).ToList();

                var outerPoint = CreateOuterPoint(outerPointCoordinates);

                Checker(rectangle, outerPoint);
            }
        }

        public static Rectangle CreateRectangle(List<int> rectangleCoordinates)
        {
            return new Rectangle(rectangleCoordinates[0], rectangleCoordinates[1],
                rectangleCoordinates[2], rectangleCoordinates[3]);
        }

        public static Point CreateOuterPoint(List<int> outerPointCoordinates)
        {
            return new Point(outerPointCoordinates[0], outerPointCoordinates[1]);
        }

        public static void Checker(Rectangle rectangle, Point outerPoint)
        {
            var result = rectangle.Contains(outerPoint);

            Print(result);
        }

        public static void Print(bool result)
        {
            Console.WriteLine(result);
        }
    }
}
