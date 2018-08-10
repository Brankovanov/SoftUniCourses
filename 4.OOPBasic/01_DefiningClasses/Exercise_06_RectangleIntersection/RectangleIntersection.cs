using System;
using System.Collections.Generic;

namespace Exercise_06_RectangleIntersection
{
    public class RectangleIntersection
    {
        public static void Main()
        {
            ReceiveRectangles();
        }

        //Receives the rectangles coordinates and dimentions from the console.
        public static void ReceiveRectangles()
        {
            var numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var listOfRectangles = new List<Rectangle>();
            var numberOfRectangles = int.Parse(numbers[0]);
            var numberOfIntersection = int.Parse(numbers[1]);

            for (var rectangle = 1; rectangle <= numberOfRectangles; rectangle++)
            {
                var information = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var identification = information[0];
                var rectangleWidth = double.Parse(information[1]);
                var rectangleHight = double.Parse(information[2]);
                var horizontal = double.Parse(information[3]);
                var vertical = double.Parse(information[4]);
                var newRectangle = new Rectangle(identification, rectangleWidth, rectangleHight, horizontal, vertical);
                listOfRectangles.Add(newRectangle);
            }

            for (var intersection = 1; intersection <= numberOfIntersection; intersection++)
            {
                var ids = Console.ReadLine().Split(' ');
                Check(listOfRectangles, ids);
            }
        }

        //Checks if the rectangles intersect.
        public static void Check(List<Rectangle> listOfRectangles, string[] ids)
        {
            if (listOfRectangles.Find(r => r.Id == ids[0]).UpperLeftCornerHorizontal > listOfRectangles.Find(r => r.Id == ids[1]).LowerRightCornerHorizontal
             || listOfRectangles.Find(r => r.Id == ids[1]).UpperLeftCornerHorizontal > listOfRectangles.Find(r => r.Id == ids[0]).LowerRightCornerHorizontal)
            {
                if (listOfRectangles.Find(r => r.Id == ids[0]).UpperLeftCornerVertical > listOfRectangles.Find(r => r.Id == ids[1]).LowerRightCornerVertical
             || listOfRectangles.Find(r => r.Id == ids[1]).UpperLeftCornerVertical > listOfRectangles.Find(r => r.Id == ids[0]).LowerRightCornerVertical)
                {
                    Console.WriteLine("false");
                }
                else
                {
                    Console.WriteLine("true");
                }
            }
            else
            {
                Console.WriteLine("true");
            }
        }
    }
}