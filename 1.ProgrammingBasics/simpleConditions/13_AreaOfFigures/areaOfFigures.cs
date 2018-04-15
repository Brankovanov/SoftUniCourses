using System;

namespace _13_AreaOfFigures
{
    public class areaOfFigures
    {
        public static void Main(string[] args)
        {
            var figure = Console.ReadLine();
            var area = 0.0;

            switch (figure)
            {
                case "square":
                    var side = double.Parse(Console.ReadLine());
                    area = side * side;
                    break;
                case "rectangle":
                    var firstSide = double.Parse(Console.ReadLine());
                    var secondSide = double.Parse(Console.ReadLine());
                    area = firstSide * secondSide;
                    break;
                case "circle":
                    var radius = double.Parse(Console.ReadLine());
                    area = Math.PI * (radius * radius);
                    break;
                case "triangle":
                    side = double.Parse(Console.ReadLine());
                    var hight = double.Parse(Console.ReadLine());
                    area = (side * hight) / 2;
                    break;
            }

            Console.WriteLine(Math.Round(area, 3));
        }
    }
}
