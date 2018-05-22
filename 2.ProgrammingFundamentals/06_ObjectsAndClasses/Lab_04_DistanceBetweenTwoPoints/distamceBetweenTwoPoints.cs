using System;

namespace Lab_04_DistanceBetweenTwoPoints
{
    public class distamceBetweenTwoPoints
    {
        public static void Main(string[] args)
        {
            ReceiveCoordinates();
        }

        //Получава координатите на точки.
        static void ReceiveCoordinates()
        {
            var firstPointXY = Console.ReadLine().Split(' ');
            var secondPointXY = Console.ReadLine().Split(' ');

            var firstPointX = int.Parse(firstPointXY[0]);
            var firstPointY = int.Parse(firstPointXY[1]);
            var secondPointX = int.Parse(secondPointXY[0]);
            var secondPointY = int.Parse(secondPointXY[1]);

            CalulateDiagonals(firstPointX, firstPointY, secondPointX, secondPointY);
        }

        //Извиква класа Point.
        static void CalulateDiagonals(int firstPointX, int firstPointY, int secondPointX, int secondPointY)
        {
            Point diagonalOne = new Point(firstPointX, firstPointY);
            diagonalOne.X = firstPointX;
            diagonalOne.Y = firstPointY;

            Point diagonalTwo = new Point(secondPointX, secondPointY);
            diagonalTwo.X = secondPointX;
            diagonalTwo.Y = secondPointY;

            CalculateSide(diagonalOne, diagonalTwo);
        }

        //Изчислява дължината на страните.
        static void CalculateSide(Point diagonalOne, Point diagonalTwo)
        {
            var sideA = Math.Abs(diagonalOne.X - diagonalTwo.X);
            var sideB = Math.Abs(diagonalOne.Y - diagonalTwo.Y);

            CalculateDistance(sideA, sideB);
        }

        //Изчислява разстоянието между точките.
        static void CalculateDistance(double sideA, double sideB)
        {
            var distance = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));

            PrintDistance(distance);
        }

        //Принтира резултата,
        static void PrintDistance(double distance)
        {
            Console.Write(String.Format("{0:0.000}",distance));
        }
    }

    //Създава точка и изчислява страна.
    public class Point
    {
        private double x;
        private double y;

        public double X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        public double Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }

        public Point(double x,double y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
