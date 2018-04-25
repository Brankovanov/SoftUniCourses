using System;

namespace Exercise_08_CentrePoint
{
    public class centerPoint
    {
        public static void Main(string[] args)
        {
            var firstPointX = double.Parse(Console.ReadLine());
            var firstPointY = double.Parse(Console.ReadLine());
            var secondPointX = double.Parse(Console.ReadLine());
            var secondPointY = double.Parse(Console.ReadLine());

            DetermineCentrePoint(firstPointX, firstPointY, secondPointX, secondPointY);
        }

        static void DetermineCentrePoint(double firstPointX, double firstPointY, double secondPointX, double secondPointY)
        {
            var firstDiagonal = Math.Sqrt(Math.Pow(Math.Abs(firstPointX - firstPointY), 2) + Math.Pow(Math.Abs(firstPointX - firstPointY), 2));
            var secondDiagonal = Math.Sqrt(Math.Pow(Math.Abs(secondPointX - secondPointY), 2) + Math.Pow(Math.Abs(secondPointX - secondPointY), 2));

            if (firstDiagonal < secondDiagonal)
            {
                Console.Write($"({firstPointX}, {firstPointY})");
            }
            else if (firstDiagonal > secondDiagonal)
            {
                Console.Write($"({secondPointX}, {secondPointY})");
            }
            else if (firstDiagonal == secondDiagonal)
            {
                Console.Write($"({firstPointX}, {firstPointY})");
            }
        }
    }
}
