using System;

namespace Exercise_01_Box
{
    public class StartUp
    {
        public static void Main()
        {
            ReceiveBoxDimentions();
        }

        //Receives the dimentions of the box from the console.
        public static void ReceiveBoxDimentions()
        {
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            CreateBox(length, width, height);
        }

        //Creates a new box with the received parameters.
        public static void CreateBox(double length, double width, double height)
        {
            try
            {
                var newBox = new Box(length, width, height);
                PrintResults(newBox);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Prints the surface arean, the lateral area and the volume of the box.
        public static void PrintResults(Box newBox)
        {
            Console.WriteLine("Surface Area - " + string.Format("{0:0.00}", newBox.SurfaceArea()));
            Console.WriteLine("Lateral Surface Area - " + string.Format("{0:0.00}", newBox.LateralSurface()));
            Console.WriteLine("Volume - " + string.Format("{0:0.00}", newBox.Volume()));
        }
    }
}