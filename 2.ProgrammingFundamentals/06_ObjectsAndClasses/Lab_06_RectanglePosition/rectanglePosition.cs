using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_06_RectanglePosition
{
    public class rectanglePosition
    {
        public static void Main(string[] args)
        {
            ReceiveCoordinates();
        }

        //Получава координатите на правоъгълниците.
        static void ReceiveCoordinates()
        {
            List<string> tempList = new System.Collections.Generic.List<string>();
            var firstRectangle = Console.ReadLine();
            var secondRectangle = Console.ReadLine();

            tempList.Add(firstRectangle);
            tempList.Add(secondRectangle);

            CalculatePoints(tempList);
        }

        //Изчислява положението на точките.
        static void CalculatePoints(List<string> tempList)
        {
            List<Rectangle> rectangleList = new List<Rectangle>();
            foreach (var coordinates in tempList)
            {
                var temp = coordinates.Split(' ').ToList();
                var leftSide = int.Parse(temp[0].ToString());
                var upSide = int.Parse(temp[1].ToString());
                var rightSide = leftSide + int.Parse(temp[2].ToString());
                var downSide = upSide + int.Parse(temp[3].ToString());

                CreateRectangles(leftSide, upSide, rightSide, downSide, rectangleList);
            }
            CompareRectangles(rectangleList);
        }

        //Създава правоъгълници.
        static void CreateRectangles(int leftSide, int upSide, int rightSide, int downSide, List<Rectangle> rectangleList)
        {           
            Rectangle rectangle = new Rectangle();
            rectangle.Left = leftSide;
            rectangle.Up = upSide;
            rectangle.Right = rightSide;
            rectangle.Down = downSide;
            rectangleList.Add(rectangle);            
        }

        //Сравнява правоъгълници.
        static void CompareRectangles(List<Rectangle> rectangleList)
        {
            if (rectangleList[0].Left < rectangleList[1].Left
              ||rectangleList[0].Right > rectangleList[1].Right
              ||rectangleList[0].Up < rectangleList[1].Up
              || rectangleList[0].Down > rectangleList[1].Down)
            {
                Console.Write("Not inside");
            }
            else
            {
                Console.Write("Inside");
            }
        }
    }

    //Създава правоъгълник.
    public class Rectangle
    {
        private int left;
        private int up;
        private int right;
        private int down;

        public int Left
        {
            get
            {
                return this.left;
            }
            set
            {
                this.left = value;
            }
        }

        public int Up
        {
            get
            {
                return this.up;
            }
            set
            {
                this.up = value;
            }
        }

        public int Right
        {
            get
            {
                return this.right;
            }
            set
            {
                this.right = value;
            }
        }

        public int Down
        {
            get
            {
                return this.down;
            }
            set
            {
                this.down = value;
            }
        }

        public Rectangle()
        {
            this.Left = left;
            this.Up = up;
            this.Right = right;
            this.Down = down;
        }
    }
}