using System;

namespace Lab_02_Shapes
{
    public class startUp
    {
        static void Main( )
        {
            var newCircle = new Circle(3);
            Console.WriteLine(newCircle.CalculateArea());
            Console.WriteLine(newCircle.CalculatePerimeter());
            Console.WriteLine(newCircle.Draw());


            var newRectangle = new Rectangle(3, 5);
            Console.WriteLine(newRectangle.CalculateArea());
            Console.WriteLine(newRectangle.CalculatePerimeter());
            Console.WriteLine(newRectangle.Draw());

        }
    }
}