using System;

namespace Exercise_11_DrawingTool
{
    public class DrawingTool
    {
        public static void Main()
        {
            ReceiveParameters();
        }

        //Receives figure parameters from the console.
        public static void ReceiveParameters()
        {
            var figure = Console.ReadLine();

            switch (figure)
            {
                case "Square":

                    var side = int.Parse(Console.ReadLine());
                    var newSquare = new Square(side, side);
                    var newDrawTool = new DrawingTools(newSquare.Widht, newSquare.Lenght);
                    Drawing(newDrawTool);
                    break;

                case "Rectangle":

                    var widht = int.Parse(Console.ReadLine());
                    var lenght = int.Parse(Console.ReadLine());
                    var newRectangle = new Rectangle(widht, lenght);
                    newDrawTool = new DrawingTools(newRectangle.Widht, newRectangle.Lenght);
                    Drawing(newDrawTool);
                    break;
            }
        }

        //Draws the figure.
        public static void Drawing(DrawingTools newDrawTool)
        {
            newDrawTool.Draw(newDrawTool.Widht, newDrawTool.Lenght);
        }
    }
}