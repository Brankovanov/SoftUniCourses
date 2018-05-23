using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_04_DistanceBetweenTwoPoints
{
    public class distamceBetweenTwoPoints
    {
        public static void Main(string[] args)
        {
            ReceiveCoordinates();
        }

        //Приема координатите на точките.
        static void ReceiveCoordinates()
        {
            List<string> setOfCoordinates = new List<string>();

            var numberOfPoints = int.Parse(Console.ReadLine());

            for (var index = 0; index <= numberOfPoints - 1; index++)
            {
                setOfCoordinates.Add(Console.ReadLine());
            }

            GetCoordinates(setOfCoordinates);
        }

        //Отделя отделните координати на точките.
        static void GetCoordinates(List<string> setOfCoordinates)
        {
            SortedDictionary<double, string> listOfCoordinates = new SortedDictionary<double, string>();
            List<string> firstTemp = new List<string>();
            List<string> secondTemp = new List<string>();
            var firstKey = string.Empty;
            var secondKey = string.Empty;
            var firstPointX = 0;
            var firstPointY = 0;
            var secondPointX = 0;
            var secondPointY = 0;

            for (var index = 0; index <= setOfCoordinates.Count - 1; index++)
            {
                firstTemp = setOfCoordinates[index].Split(' ').ToList();
                firstPointX = int.Parse(firstTemp[0]);
                firstPointY = int.Parse(firstTemp[1]);
                firstKey = setOfCoordinates[index];

                for (var innerIndex = 0; innerIndex <= setOfCoordinates.Count - 1; innerIndex++)
                {
                    if (innerIndex != index)
                    {
                        secondTemp = setOfCoordinates[innerIndex].Split(' ').ToList();
                        secondPointX = int.Parse(secondTemp[0]);
                        secondPointY = int.Parse(secondTemp[1]);
                        secondKey = setOfCoordinates[innerIndex];

                        CalulateDiagonals(firstPointX, firstPointY, secondPointX, secondPointY, listOfCoordinates, firstKey, secondKey);

                        secondTemp.Clear();
                        secondPointX = 0;
                        secondPointY = 0;
                    }
                }

                firstTemp.Clear();
                firstPointX = 0;
                firstPointY = 0;
                firstKey = string.Empty;
                secondKey = string.Empty;
            }

            Print(listOfCoordinates);
        }

        //Извиква класа Point.
        static void CalulateDiagonals(int firstPointX, int firstPointY, int secondPointX, int secondPointY, SortedDictionary<double, string> listOfCoordinates, string firstKey, string secondKey)
        {
            Point diagonalOne = new Point(firstPointX, firstPointY);
            diagonalOne.X = firstPointX;
            diagonalOne.Y = firstPointY;

            Point diagonalTwo = new Point(secondPointX, secondPointY);
            diagonalTwo.X = secondPointX;
            diagonalTwo.Y = secondPointY;

            CalculateSide(diagonalOne, diagonalTwo, listOfCoordinates, firstKey, secondKey);
        }

        //Изчислява дължината на страните.
        static void CalculateSide(Point diagonalOne, Point diagonalTwo, SortedDictionary<double, string> listOfCoordinates, string firstKey, string secondKey)
        {
            var sideA = Math.Abs(diagonalOne.X - diagonalTwo.X);
            var sideB = Math.Abs(diagonalOne.Y - diagonalTwo.Y);

            CalculateDistance(sideA, sideB, listOfCoordinates, firstKey, secondKey);
        }

        //Изчислява разстоянието между точките.
        static void CalculateDistance(double sideA, double sideB, SortedDictionary<double, string> listOfCoordinates, string firstKey, string secondKey)
        {
            var distance = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));

            if (!listOfCoordinates.ContainsKey(distance))
            {
                string value = firstKey + " " + secondKey;
                listOfCoordinates.Add(distance, value);
            }
        }

        //Принтира изход.
        static void Print(SortedDictionary<double, string> listOfCoordinates)
        {
            List<string> print = new List<string>();

            Console.WriteLine(String.Format("{0:0.000}", listOfCoordinates.Keys.First()));
            print = listOfCoordinates[listOfCoordinates.Keys.First()].Split(' ').ToList();

            var pointCoordinate = "(";

            for (var i = 0; i <= 1; i++)
            {
                pointCoordinate += print[i] + ", ";
            }

            pointCoordinate = pointCoordinate.Remove(pointCoordinate.Length - 2, 2);
            pointCoordinate += ")";
            Console.WriteLine(pointCoordinate);
            pointCoordinate = string.Empty;

            pointCoordinate = "(";

            for (var i = 2; i <= 3; i++)
            {
                pointCoordinate += print[i] + ", ";
            }

            pointCoordinate = pointCoordinate.Remove(pointCoordinate.Length - 2, 2);
            pointCoordinate += ")";
            Console.WriteLine(pointCoordinate);
            pointCoordinate = string.Empty;
        }
    }

    //Приема координатите на точка и я създава.
    public class Point
    {
        private int x;
        private int y;

        public int X
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

        public int Y
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

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}