using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercis_03_IntersectionCircles
{
    public class intersectionCircles
    {
        public static void Main(string[] args)
        {
            ReceiveCoordinates();
        }

        //Получава координатите на двата кръга от конзолата, като текст.
        static void ReceiveCoordinates()
        {
            var firstCircle = Console.ReadLine();
            var secondCircle = Console.ReadLine();

            SplitAndParseCoordinate(firstCircle, secondCircle);
        }

        //Преобразува текста получен от конзолата.
        static void SplitAndParseCoordinate(string firstCircle, string secondCircle)
        {
            List<double> firstCircleCoordinate = new List<double>();
            List<double> secondCircleCoordinate = new List<double>();

            firstCircleCoordinate = firstCircle.Split(' ').Select(x => double.Parse(x.ToString())).ToList();
            secondCircleCoordinate = secondCircle.Split(' ').Select(y => double.Parse(y.ToString())).ToList();

            CreateCircle(firstCircleCoordinate, secondCircleCoordinate);
        }

        //Извиква класа Circlen и създава нови кръгове. 
        static void CreateCircle(List<double> firstCircleCoordinate, List<double> secondCircleCoordinate)
        {
            Circles circleOne = new Circles();
            circleOne.X = firstCircleCoordinate[0];
            circleOne.Y = firstCircleCoordinate[1];
            circleOne.R = firstCircleCoordinate[2];

            Circles circleTwo = new Circles();
            circleTwo.X = secondCircleCoordinate[0];
            circleTwo.Y = secondCircleCoordinate[1];
            circleTwo.R = secondCircleCoordinate[2];

            CalculateDistance(circleOne, circleTwo);
        }

        //Изчислява разстоянието между центровете на кръговете.
        static void CalculateDistance(Circles circleOne, Circles circleTwo)
        {
            var intersect = (Math.Sqrt(Math.Pow((circleTwo.X - circleOne.X), 2) + Math.Pow((circleTwo.Y - circleOne.Y), 2)))
                - (circleOne.R + circleTwo.R);

            PrintOutput(intersect);
        }

        //Принтира отговор в зависимост дали двете окръжности се присичат.
        static void PrintOutput(double intersect)
        {
            if (intersect <= 0)
            {
                Console.Write("Yes");
            }
            else
            {
                Console.Write("No");
            }
        }
    }

    //Създава обект Circle.
    public class Circles
    {
        private double x;
        private double y;
        private double r;

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

        public double R
        {
            get
            {
                return this.r;
            }
            set
            {
                this.r = value;
            }
        }

        public Circles()
        {
            this.x = X;
            this.y = Y;
            this.r = R;
        }
    }
}