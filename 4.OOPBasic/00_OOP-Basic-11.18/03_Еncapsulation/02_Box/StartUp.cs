using System;

namespace _02_Box
{
    public class StartUp
    {
        public static void Main()
        {
            Input();
        }

        public static void Input()
        {
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            Calculate(length, width, height);
        }

        public static void Calculate(double length, double width, double height)
        {
            try
            {
                var newBox = new Box(length, width, height);

                var surfaceArea = newBox.SurfaceArea();
                var lateralSurface = newBox.LatheralSurface();
                var volume = newBox.Volume();

                PrintResult(surfaceArea, lateralSurface, volume);
            }
            catch(ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        public static void PrintResult(double surfaceArea, double lateralSurface, double volume)
        {
            Console.WriteLine($"Surface Area – {string.Format("{0:0.00}",surfaceArea)} {Environment.NewLine}" +
                $"Lateral Surface Area – {string.Format("{0:0.00}",lateralSurface)} {Environment.NewLine}" +
                $"Volume – {string.Format("{0:0.00}", volume)}");
        }
    }
}
