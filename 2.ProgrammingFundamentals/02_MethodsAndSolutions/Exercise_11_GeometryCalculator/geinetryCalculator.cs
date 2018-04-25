using System;

namespace Exercise_11_GeometryCalculator
{
    public class geinetryCalculator
    {
        public static void Main(string[] args)
        {
            var typeOfFigure = string.Empty;

            TypeOfFigureInput(typeOfFigure);
        }

        static void TypeOfFigureInput (string typeOfFigure)
        {
            typeOfFigure = Console.ReadLine();

            if(typeOfFigure.Equals("triangle"))
            {
                Console.Write($"{CalculateTriangleArea():F2}");
            }
            else if (typeOfFigure.Equals("square"))
            {
                Console.Write($"{CalculateSquareArea():F2}");
            }
            else if (typeOfFigure.Equals("rectangle"))
            {
                Console.Write($"{CalculateRectangleArea():F2}");
            }
            else if (typeOfFigure.Equals("circle"))
            {
                Console.Write($"{CalculateCircleArea():F2}");
            }
        }

        static double CalculateTriangleArea()
        {
            var side = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            return (side * height) / 2;
        }

        static double CalculateSquareArea()
        {
            var side = double.Parse(Console.ReadLine());

            return Math.Pow(side,2);
        }

        static double CalculateRectangleArea()
        {
            var sideA = double.Parse(Console.ReadLine());
            var sideB = double.Parse(Console.ReadLine());

            return sideA*sideB;
        }

        static double CalculateCircleArea()
        {
            var radius = double.Parse(Console.ReadLine());
            
            return Math.PI*Math.Pow(radius,2);
        }
    }
}