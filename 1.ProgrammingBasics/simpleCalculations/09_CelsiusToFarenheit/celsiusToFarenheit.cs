using System;

namespace _09_CelsiusToFarenheit
{
    public class celsiusToFarenheit
    {
        public static void Main(string[] args)
        {
            var celsius = double.Parse(Console.ReadLine());

            var farenheit = (celsius * 1.8000) + 32;

            Console.WriteLine(Math.Round(farenheit, 2));
        }
    }
}
