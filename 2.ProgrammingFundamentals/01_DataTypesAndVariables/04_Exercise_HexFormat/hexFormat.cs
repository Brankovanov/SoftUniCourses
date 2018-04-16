using System;

namespace _04_Exercise_HexFormat
{
    public class hexFormat
    {
        public static void Main(string[] args)
        {
            var hexFormat = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32(hexFormat, 16));
        }
    }
}
