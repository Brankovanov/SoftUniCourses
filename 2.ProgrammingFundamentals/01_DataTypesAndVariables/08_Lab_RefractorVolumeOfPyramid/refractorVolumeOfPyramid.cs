using System;

namespace _08_Lab_RefractorVolumeOfPyramid
{
    public class refractorVolumeOfPyramid
    {
        public static void Main(string[] args)
        {
            Console.Write("Length: ");
            var lenght = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            var widht = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            var height = double.Parse(Console.ReadLine());

            var volume = (lenght * widht * height) / 3;

            Console.WriteLine("Pyramid Volume: {0:F2}", volume);
        }
    }
}
