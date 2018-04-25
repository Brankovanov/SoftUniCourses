using System;

namespace Exercise_09_LongerLine
{
    public class longerLine
    {
        public static void Main(string[] args)
        {
            var x1 = 0.0;
            var y1 = 0.0;
            var x2 = 0.0;
            var y2 = 0.0;
            var x3 = 0.0;
            var y3 = 0.0;
            var x4 = 0.0;
            var y4 = 0.0;

            Input(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        static void Input(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            x3 = double.Parse(Console.ReadLine());
            y3 = double.Parse(Console.ReadLine());
            x4 = double.Parse(Console.ReadLine());
            y4 = double.Parse(Console.ReadLine());

            var firstLine = FirstLine(x1, y1, x2, y2);
            var secondLine = SecondLine(x3, y3, x4, y4);

            CompareLines(firstLine, secondLine,
                x1, y1, x2, y2,
                x3, y3, x4, y4);
        }

        static double FirstLine(double x1, double y1, double x2, double y2)
        {
            var firstDiagonal = Math.Sqrt(Math.Pow(Math.Abs(x1), 2) + Math.Pow(Math.Abs(y1), 2));
            var secondDiagonal = Math.Sqrt(Math.Pow(Math.Abs(x2), 2) + Math.Pow(Math.Abs(y2), 2));

            return firstDiagonal + secondDiagonal;
        }

        static double SecondLine(double x3, double y3, double x4, double y4)
        {
            var thirdDiagonal = Math.Sqrt(Math.Pow(Math.Abs(x3), 2) + Math.Pow(Math.Abs(y3), 2));
            var fouthDiagonal = Math.Sqrt(Math.Pow(Math.Abs(x4), 2) + Math.Pow(Math.Abs(y4), 2));

            return thirdDiagonal + fouthDiagonal;
        }

        static void CompareLines(double firstLine, double secondLine,
            double x1, double y1, double x2, double y2,
            double x3, double y3, double x4, double y4)
        {
            if (firstLine > secondLine)
            {
                if (x1 <= x2 || y1 <= y2)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else if (secondLine > firstLine)
            {
                if (x3 >= x4 || y3 >= y4)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
            else if (firstLine == secondLine)
            {           
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");               
            }
        }
    }
}
